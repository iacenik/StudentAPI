using Book_Store_API.Data;
using Book_Store_API.Models.Class;
using Book_Store_API.Services.Abstractions;

namespace Book_Store_API.Services.Implementations
{
    public class ClassService:IClassService
    {
        private readonly AppDbContext _context;
        public ClassService(AppDbContext context)
        {
            _context = context;
        }

        public Task CreateClass(CreateClassRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClassViewModel>> GetClassList()
        {
            throw new NotImplementedException();
        }
    }
}
