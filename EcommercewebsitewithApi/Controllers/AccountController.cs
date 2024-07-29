using EcommercewebsitewithApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EcommercewebsitewithApi.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class AccountController : ControllerBase
    {

        private readonly MyDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public AccountController(MyDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _configuration = configuration;

        }
        [HttpGet("GetUserData")]
        public IActionResult Index()
        {
            var user = _context.Users.Include(p => p.Company).Include(s => s.Status).ToList();
            return Ok(user);
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> Create([FromBody] User model)
        {
            
                var user = new ApplicationUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    CompanyId = model.CompanyId,
                    StatusId = 6,
                    PasswordHash = model.Password,
                    createdate = DateTime.Now,
                    Lastmodifieddate = DateTime.Now,
                    
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var role = await _roleManager.FindByNameAsync(model.Name);

                    if (role != null)
                    {
                        if (user != null)
                        {
                            await _userManager.AddToRoleAsync(user, role.Name);

                            if (result.Succeeded)
                            {
                                return Ok("User created and role assigned successfully");
                            }
                            else
                            {
                                return BadRequest("Failed to assign role to user. " + string.Join(", ", result.Errors.Select(e => e.Description)));
                            }
                        }
                        await _signInManager.SignInAsync(user, isPersistent: false);
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                }
            return Ok();

        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] Login model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                     var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)

                    );
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }
    }
}
