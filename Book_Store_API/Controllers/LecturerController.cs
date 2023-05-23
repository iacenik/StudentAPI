using Book_Store_API.Data;
using Book_Store_API.Models.Exam;
using Book_Store_API.Models.Lecturer;
using Book_Store_API.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Book_Store_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecturerController:ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILecturerService _service;
        public LecturerController(AppDbContext context, ILecturerService service)
        {
            _context = context;
            _service = service;
        }
        [HttpGet("get-all-lecturer")]
        public async Task<ActionResult<List<LecturerViewModel>>> GetAllLecturer()
        {
            var response = await _service.GetAllLecturer();
            return Ok(response);
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateLecturer(CreateLecturerRequestModel model)
        {
            await _service.CreateLecturer(model);
            return NoContent();
        }
    }
}
