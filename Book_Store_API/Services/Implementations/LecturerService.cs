using Book_Store_API.Data;
using Book_Store_API.Data.Entities;
using Book_Store_API.Models.Lecturer;
using Book_Store_API.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_API.Services.Implementations
{
    public class LecturerService:ILecturerService
    {
        private readonly AppDbContext _context;
        public LecturerService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateLecturer(CreateLecturerRequestModel model)
        {
            var newLecturer = new Lecturer
            {
                LecturerName = model.LecturerName,
                Age = model.Age,
                Title = model.Title
         
            };

            await _context.AddAsync(newLecturer);
            try
            {
                await _context.SaveChangesAsync();

            }
            catch   (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<LecturerViewModel>> GetAllLecturer()
        {
            var response = await _context.Lecturers.Where(x => !x.IsDeleted).ToListAsync();
            var dtoResponse = response.Select(x => new LecturerViewModel
            {
                LecturerName = x.LecturerName,
                Age = x.Age,
                Title = x.Title
            }).ToList();
            return dtoResponse;
        }
    }
}
