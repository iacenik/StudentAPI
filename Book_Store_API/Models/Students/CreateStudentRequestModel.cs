namespace Book_Store_API.Models.Students
{
    public class CreateStudentRequestModel
    {
        public string FullName { get; set; }
        public int ClassId { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
