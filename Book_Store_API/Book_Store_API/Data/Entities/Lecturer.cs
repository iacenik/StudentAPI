using Book_Store_API.Data.Abstracts;

namespace Book_Store_API.Data.Entities
{
    public class Lecturer : BaseEntity
    {
        public string LecturerName { get; set; }
        public int Age { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

    }
}
