using Book_Store_API.Data;
using Book_Store_API.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Book_Store_API.Models.Course;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http;
using Book_Store_API.Models.StudentCourses;

namespace Book_Store_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCoursesController:ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IStudentCoursesService _service;
        public StudentCoursesController(AppDbContext context, IStudentCoursesService service)
        {
            _context = context;
            _service = service;
        }
        [HttpGet("get-all-studentcourses")]
        public async Task<ActionResult<List<CourseViewModel>>> GetAllStudentCourses()
        {
            var response = await _service.GetAllStudentCourses();
            return Ok(response);
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateStudentCourses(CreateStudentCoursesRequestModel model)
        {
            await _service.CreateStudentCourses(model);
            return NoContent();
        }
    }
    
}
