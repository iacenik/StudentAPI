using Book_Store_API.Data;
using Book_Store_API.Data.Entities;
using Book_Store_API.Models.Class;
using Book_Store_API.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_API.Services.Implementations
{
    public class ClassService:IClassService
    {
        private readonly AppDbContext _context;
        public ClassService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateClass(CreateClassRequestModel model)
        {
            var newClass = new Class
            {
                Capacity = model.Capacity,
                ClassName = model.ClassName
            };
            await _context.AddAsync(newClass);
            await _context.SaveChangesAsync();
           
        }

        public async Task<List<ClassViewModel>> GetClassList()
        {
            var response = await _context.Classes.Where(x => !x.IsDeleted).ToListAsync();
            var dtoResponse=response.Select(x=>new ClassViewModel
            {
                Capacity=x.Capacity,
                ClassName=x.ClassName
            }).ToList();
            return dtoResponse;
           
        }
    }
}
