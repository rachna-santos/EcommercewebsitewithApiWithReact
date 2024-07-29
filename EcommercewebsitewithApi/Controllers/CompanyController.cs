using EcommercewebsitewithApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommercewebsitewithApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly MyDbContext _context;
        public CompanyController(MyDbContext context)
        {
                _context=context;
        }
        [HttpGet("getcompany")]
        public IActionResult Index()
        {
            var comapny=_context.companies.ToList();
            return Ok(comapny);
        }        
        [HttpPost("createcompany")]
        public IActionResult Create(Company model)
        {
            model.createdate = DateTime.Now;
            model.Lastmodifieddate= DateTime.Now;
            model.StatusId = 1;
            _context.companies.Add(model);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpPost("GetEdit")]
        public IActionResult Edit(int id)
        {
            var comapny = _context.companies.Where(p => p.CompanyId == id).FirstOrDefault();
            return Ok(comapny);
        }
        [HttpPut("Editcompany")]
        public IActionResult Edit(int id,Company model)
        {
            model.createdate = DateTime.Now;
            model.Lastmodifieddate = DateTime.Now;
            model.StatusId = 1;
            _context.companies.Update(model);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var comapny= await _context.companies.FindAsync(id);    
            _context.companies.Remove(comapny);
            _context.SaveChanges();
            return Ok();
        }

    }
}
