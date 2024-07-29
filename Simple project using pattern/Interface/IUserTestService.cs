using Simple_project_using_pattern.Model.DTO;

namespace Simple_project_using_pattern.Interface
{
    public interface IUserTestService
    {
        IEnumerable<UserTestDTO> GetAllUser();
    }
}
