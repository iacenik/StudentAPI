using Book_Store_API.Models.Exam;
using Book_Store_API.Models.Students;

namespace Book_Store_API.Services.Abstractions
{
    public interface IExamService
    {
        public Task CreateExam(CreateExamRequestModel model);
        public Task<List<ExamViewModel>> GetAllExam();
    }
}
