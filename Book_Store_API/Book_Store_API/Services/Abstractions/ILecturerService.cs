using Book_Store_API.Models.Lecturer;

namespace Book_Store_API.Services.Abstractions
{
    public interface ILecturerService
    {
        public Task CreateLecturer(CreateLecturerRequestModel model);
        public Task<List<LecturerViewModel>> GetAllLecturer();  
    }
}
