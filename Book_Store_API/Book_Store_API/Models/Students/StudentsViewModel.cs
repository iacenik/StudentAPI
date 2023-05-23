using Book_Store_API.Data.Entities;
using Book_Store_API.Models.Class;
using Book_Store_API.Models.Exam;
using Book_Store_API.Models.StudentCourses;

namespace Book_Store_API.Models.Students
{
    public class StudentsViewModel
    {
        public string FullName { get; set; }
        public int ClassId { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public List<StudentCoursesViewModel> StudentCourses { get; set; }
        public List<ExamViewModel> Exams { get; set; }
        public ClassViewModel Class { get; set; }
       
    }
}
