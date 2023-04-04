using Book_Store_API.Data.Abstracts;

namespace Book_Store_API.Data.Entities
{
    public class Course : BaseEntity
    {
        public string CourseName { get; set; }
        public int LecturerId { get; set; }
        public int ExamCount { get; set; }
        public int MinPassScore { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<StudentCourses> StudentCourse { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual Lecturer Lecturer { get; set; }  

    }
}
