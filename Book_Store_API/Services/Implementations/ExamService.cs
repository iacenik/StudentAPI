using Book_Store_API.Data;
using Book_Store_API.Data.Entities;
using Book_Store_API.Models.Exam;
using Book_Store_API.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_API.Services.Implementations
{
    public class ExamService : IExamService
    {
        private readonly AppDbContext _context;
        public ExamService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateExam(CreateExamRequestModel model)
        {
            var newExam = new Exam
            {
                ExamName = model.ExamName,
                LecturerId = model.LecturerId,
                CourseId = model.CourseId,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
            };

            await _context.AddAsync(newExam);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ExamViewModel>> GetAllExam()
        {
            var response = await _context.Exams.Where(x => !x.IsDeleted).ToListAsync();
            var dtoResponse = response.Select(x => new ExamViewModel
            {
                ExamName = x.ExamName,
                LecturerId = x.LecturerId,
                CourseId = x.CourseId,
                StartDate = x.StartDate,
                EndDate = x.EndDate

            }).ToList();
            return dtoResponse;

        }
    }
}
