using Book_Store_API.Data;
using Book_Store_API.Models.StudentCourses;
using Book_Store_API.Services.Abstractions;

namespace Book_Store_API.Services.Implementations
{
    public class StudentCoursesService:IStudentCoursesService
    {
        private readonly AppDbContext _context;
      public StudentCoursesService(AppDbContext context)
        {
            _context = context;
        }

        public Task CreateStudentCourses(CreateStudentCoursesRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<List<StudentCoursesViewModel>> GetAllStudentCourses()
        {
            throw new NotImplementedException();
        }
    }
}
