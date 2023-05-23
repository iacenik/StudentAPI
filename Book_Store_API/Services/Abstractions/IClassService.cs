using Book_Store_API.Models.Class;

namespace Book_Store_API.Services.Abstractions
{
    public interface IClassService
    {
        public Task CreateClass(CreateClassRequestModel model);
        public Task<List<ClassViewModel>> GetClassList();
    }
}
