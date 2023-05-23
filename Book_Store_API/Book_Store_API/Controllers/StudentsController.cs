using Book_Store_API.Data;
using Book_Store_API.Models.Students;
using Book_Store_API.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Book_Store_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IStudentsService _service;
        public StudentsController(AppDbContext context, IStudentsService service)
        {
            _context = context;
            _service = service;
        }

        [HttpGet("get-all-students")]
        public async Task<ActionResult<List<StudentsViewModel>>> GetAllStudents()
        {
            var response = await _service.GetAllStudents();
            return Ok(response);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateStudent(CreateStudentRequestModel model)
        {
            await _service.CreateStudent(model);
            return NoContent();
        }

    }
}
