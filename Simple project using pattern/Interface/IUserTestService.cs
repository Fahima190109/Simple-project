using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Simple_project_using_pattern.Interface
{
    public interface IUserTestService
    {
        IEnumerable<UserTestDTO> GetAllUser();
        UserTestDTO GetUser(int id);
      UserTestDTO CreatNewUser(UserTestDTO userDTO);
        UserTestDTO UserDeleteId(int id);
        UserTestDTO UpdateExitUser(int id,UserTestDTO userDTO);
    }
}
