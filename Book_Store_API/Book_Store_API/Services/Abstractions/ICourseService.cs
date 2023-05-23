using Book_Store_API.Models.Course;

namespace Book_Store_API.Services.Abstractions
{
    public interface ICourseService
    {
        public Task CreateCourse(CreateCourseRequestModel model);
        public Task<List<CourseViewModel>> GetCourseAll();
    }
} 
