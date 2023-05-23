using Book_Store_API.Data;
using Book_Store_API.Models.Course;
using Book_Store_API.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Book_Store_API.Models.Lecturer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Book_Store_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ICourseService _service;

        public CourseController(AppDbContext context, ICourseService service)
        {
            _context = context;
            _service = service;
        }

        [HttpGet("get-all-course")]
        public async Task<ActionResult<List<CourseViewModel>>> GetCourseAll()
        {
            var response = await _service.GetCourseAll();
            return Ok(response);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCourse(CreateCourseRequestModel model)
        {
            await _service.CreateCourse(model);
            return NoContent();
        }
    }
}

