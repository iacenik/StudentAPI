using Book_Store_API.Data;
using Book_Store_API.Models.Class;
using Book_Store_API.Models.Exam;
using Book_Store_API.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http;

namespace Book_Store_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController:ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IClassService _service;
        public ClassController(AppDbContext context, IClassService service)
        {
            _context = context;
            _service = service;
        }
        [HttpGet("get-all-class")]
        public async Task<ActionResult<List<ClassViewModel>>> GetClassList()//Burayı sor?
        {
            var response = await _service.GetClassList();
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateClass(CreateClassRequestModel model)
        {
            await _service.CreateClass(model);
            return NoContent();
        }
    }
}
