using Book_Store_API.Data;
using Book_Store_API.Models.Course;
using Book_Store_API.Services.Abstractions;

namespace Book_Store_API.Services.Implementations
{
    public class CourseService:ICourseService
    {
        private readonly AppDbContext _context;
        public CourseService(AppDbContext context)
        {
            _context = context;
        }

        public Task CreateCourse(CreateCourseRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseViewModel>> GetCourseAll()
        {
            throw new NotImplementedException();
        }
    }
}
