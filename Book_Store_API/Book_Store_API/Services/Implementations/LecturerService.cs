using Book_Store_API.Data;
using Book_Store_API.Models.Lecturer;
using Book_Store_API.Services.Abstractions;

namespace Book_Store_API.Services.Implementations
{
    public class LecturerService:ILecturerService
    {
        private readonly AppDbContext _context;
        public LecturerService(AppDbContext context)
        {
            _context = context;
        }

        public Task CreateLecturer(CreateLecturerRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<List<LecturerViewModel>> GetAllLecturer()
        {
            throw new NotImplementedException();
        }
    }
}
