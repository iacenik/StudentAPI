namespace Book_Store_API.Models.Exam
{
    public class CreateExamRequestModel
    {
        public string ExamName { get; set; }
        public int LecturerId { get; set; }
        public int CourseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
