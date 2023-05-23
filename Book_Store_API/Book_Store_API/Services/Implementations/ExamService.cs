using Book_Store_API.Data;
using Book_Store_API.Models.Exam;
using Book_Store_API.Services.Abstractions;

namespace Book_Store_API.Services.Implementations
{
    public class ExamService : IExamService
    {
        private readonly AppDbContext _context;
        public ExamService(AppDbContext context)
        {
            _context = context;
        }

        public Task CreateExam(CreateExamRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<List<ExamViewModel>> GetAllExam()
        {
            throw new NotImplementedException();
        }
    }
}
