using Book_Store_API.Data;
using Book_Store_API.Data.Entities;
using Book_Store_API.Models.StudentCourses;
using Book_Store_API.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Book_Store_API.Services.Implementations
{
    public class StudentCoursesService:IStudentCoursesService
    {
        private readonly AppDbContext _context;
        public StudentCoursesService(AppDbContext context)
        {
            _context = context;
        }

        //public async Task CreateStudentCourses(CreateStudentCoursesRequestModel model)
        //{
        //    var newStudentCourses = new StudentCourses
        //    {
        //        StudentId = model.StudentId,
        //        CourseId = model.CourseId
        //    };
        //    await _context.SaveChangesAsync();
        //    await _context.AddAsync(newStudentCourses);
        //}

        //public async Task<List<StudentCoursesViewModel>> GetAllStudentCourses()
        //{
            
        //    var response = await _context.StudentCourses.Where(x=>!x.IsDeleted).ToListAsync();
        //    var dtoResponse=response.Select(x=>new StudentCoursesViewModel
        //    {
        //        StudentId=x.StudentId,
        //        CourseId=x.CourseId
        //    }).ToList();
        //    return dtoResponse;
        //}
    }
}
