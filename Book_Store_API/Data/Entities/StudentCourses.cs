using Book_Store_API.Data.Abstracts;

namespace Book_Store_API.Data.Entities
{
    public class StudentCourses : BaseEntity
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

    }
}
