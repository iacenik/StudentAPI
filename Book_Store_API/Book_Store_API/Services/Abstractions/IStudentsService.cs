using Book_Store_API.Models.Students;

namespace Book_Store_API.Services.Abstractions
{
    public interface IStudentsService
    {
        public Task CreateStudent(CreateStudentRequestModel model);
        public Task<List<StudentsViewModel>> GetAllStudents();
    }
}
