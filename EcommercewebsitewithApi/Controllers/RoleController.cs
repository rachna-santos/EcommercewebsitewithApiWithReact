using EcommercewebsitewithApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommercewebsitewithApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        public RoleController(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager=roleManager;
        }
        [HttpGet("GetRole")]
        public IActionResult Index()
        {
            var product =_roleManager.Roles.ToList();
            return Ok(product);
        }
        [HttpPost("CreateRole")]
        public async Task<IActionResult> Create([FromBody] Role model)
        {
            ApplicationRole identityRole = new ApplicationRole
            {
                Name = model.Name,
                CompanyId = model.CompanyId,
                StatusId = model.StatusId,
                createdate = DateTime.Now,
                Lastmodifieddate = DateTime.Now,
                NormalizedName = model.Name,
            };
            IdentityResult result = await _roleManager.CreateAsync(identityRole);
            if (result.Succeeded)
            {
                return Ok(model);
            }
            return Ok(model);
        }
        
    }
}
