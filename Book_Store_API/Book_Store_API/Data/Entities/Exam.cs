using Book_Store_API.Data.Abstracts;

namespace Book_Store_API.Data.Entities
{
    public class Exam : BaseEntity
    {
        public string ExamName { get; set; }
        public int LecturerId { get; set; }
        public int CourseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public virtual Course Course { get; set; }
    }
}
