namespace Book_Store_API.Models.Course
{
    public class CourseViewModel
    {
        public string CourseName { get; set; }
        public int LecturerId { get; set; }
        public int ExamCount { get; set; }
        public int MinPassScore { get; set; }
        public int Capacity { get; set; }
    }
}
