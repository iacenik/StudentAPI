using Book_Store_API.Data.Abstracts;

namespace Book_Store_API.Data.Entities
{
    public class Student : BaseEntity
    {
        public string FullName { get; set; }
        public int ClassId { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual Class Class { get; set; }
    }
}
