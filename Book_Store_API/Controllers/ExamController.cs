using Book_Store_API.Data;
using Book_Store_API.Models.Exam;
using Book_Store_API.Models.Students;
using Book_Store_API.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Book_Store_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IExamService _service;
        public ExamController(AppDbContext context,IExamService service)
        {
            _context = context;
            _service = service;
        }


        [HttpGet("get-all-exam")]
        public async Task<ActionResult<List<ExamViewModel>>> GetAllExam()
        {
            var response = await _service.GetAllExam();
            return Ok(response);
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateExam(CreateExamRequestModel model)
        {
            await _service.CreateExam(model);
            return NoContent();
        }
    }
}
