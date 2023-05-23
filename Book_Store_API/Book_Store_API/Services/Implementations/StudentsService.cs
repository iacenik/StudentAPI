using Book_Store_API.Data;
using Book_Store_API.Data.Entities;
using Book_Store_API.Models.Students;
using Book_Store_API.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_API.Services.Implementations
{
    public class StudentsService : IStudentsService
    {
        private readonly AppDbContext _context;
        public StudentsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<StudentsViewModel>> GetAllStudents()
        {
            var response = await _context.Students.Where(x=>!x.IsDeleted)
                                                  .Include(x=>x.Class)
                                                  .Include(x=>x.StudentCourses)
                                                  .Include(x=>x.Exams)
                                                  .ToListAsync();

            var dtoResponse = response.Select(x=> new StudentsViewModel
            {
                FullName = x.FullName,
                Age = x.Age,
                Gender = x.Gender,
                ClassId = x.ClassId,
                Class = new Models.Class.ClassViewModel
                {
                    Capacity = x.Class.Capacity,
                    ClassName = x.Class.ClassName,
                },
                Exams = x.Exams.Select(x=> new Models.Exam.ExamViewModel
                {
                    CourseId = x.CourseId,
                    EndDate = x.EndDate,
                    ExamName = x.ExamName,
                    LecturerId = x.LecturerId,
                    StartDate = x.StartDate
                }).ToList(),
                StudentCourses = x.StudentCourses.Select(x=>new Models.StudentCourses.StudentCoursesViewModel
                {
                    CourseId=x.CourseId,
                    StudentId =x.StudentId,
                }).ToList()
            }).ToList();

            return dtoResponse;
        }

        public async Task CreateStudent(CreateStudentRequestModel model)
        {
            var entity = new Student
            {
                Age = model.Age,
                ClassId = model.ClassId,
                FullName = model.FullName,
                Gender = model.Gender,
            };

            try
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        
    }
}
