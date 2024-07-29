using Simple_project_using_pattern.Interface;
using Simple_project_using_pattern.Model.DTO;

namespace Simple_project_using_pattern.Service
{
    public class UserTestService : IUserTestService
    {
        private static readonly List<UserTestDTO> Villas = new List<UserTestDTO>
    {
        new UserTestDTO { Id = 1, Name = "Mehek" },
        new UserTestDTO { Id = 2, Name = "Fahima" }
    };

        public IEnumerable<UserTestDTO> GetAllUser() => Villas;


    }
}
