using Book_Store_API.Data.Abstracts;

namespace Book_Store_API.Data.Entities
{
    public class Class : BaseEntity
    {
        public string ClassName { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
