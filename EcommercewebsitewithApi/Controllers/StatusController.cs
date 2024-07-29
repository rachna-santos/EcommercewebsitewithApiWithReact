using EcommercewebsitewithApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommercewebsitewithApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly MyDbContext _context;
        public StatusController(MyDbContext context)
        {
            _context = context;  
        }
        [HttpGet("GetStatus")]
        public IActionResult Index() 
        {
            var ststus = _context.Statuses.ToList();
            return Ok(ststus);
        }
        
        [HttpPost("CreateStatus")]
        public IActionResult Create(Status model)
        {
            _context.Statuses.Add(model);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpGet("EditStatId")]
        public IActionResult Edit(int id)
        {
            var ststus = _context.Statuses.Where(p => p.StatusId == id).FirstOrDefault();
            return Ok(ststus);
        }
        [HttpPut("EditStatusId")]
        public IActionResult Edit(int id,Status model)
        {
            _context.Statuses.Update(model);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpDelete("DeleteStatus")]
        public async Task<IActionResult> Delete(int id)
        {
           var data= await _context.Statuses.FindAsync(id);
            _context.Statuses.Remove(data);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
