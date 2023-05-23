using Book_Store_API.Data;
using Book_Store_API.Data.Entities;
using Book_Store_API.Models.Course;
using Book_Store_API.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_API.Services.Implementations
{
    public class CourseService:ICourseService
    {
        private readonly AppDbContext _context;
        public CourseService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateCourse(CreateCourseRequestModel model)
        {
            var newCourse = new Course
            {
                CourseName = model.CourseName,
                LecturerId = model.LecturerId,
                ExamCount = model.ExamCount,
                MinPassScore = model.MinPassScore,
                Capacity = model.Capacity,
            };
            
            await _context.AddAsync(newCourse);
            await _context.SaveChangesAsync();
        }

        public async Task<List<CourseViewModel>> GetCourseAll()
        {
            var response = await _context.Courses.Where(x => !x.IsDeleted).ToListAsync();
            var dtoResponse = response.Select(x => new CourseViewModel
            {
                CourseName = x.CourseName,
                LecturerId = x.LecturerId,
                ExamCount = x.ExamCount,
                MinPassScore = x.MinPassScore,
                Capacity = x.Capacity,
            }).ToList();
            return dtoResponse;
        }
    }
}
