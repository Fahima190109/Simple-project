using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Simple_project_using_pattern.Interface;
using Project.Models;

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
        public UserTestDTO GetUser(int id)
        {
            return Villas.FirstOrDefault(x => x.Id == id);
        }
        public UserTestDTO CreatNewUser(UserTestDTO userDTO)
        {
            if (Villas.FirstOrDefault(u => u.Name.ToLower() == userDTO.Name.ToLower()) != null)
            {

               return null;
            }
            userDTO.Id = Villas.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            Villas.Add(userDTO);
            return userDTO;
        }
       public UserTestDTO UserDeleteId(int id)
        {
          var deletUser = Villas.FirstOrDefault(u => u.Id == id);
           Villas.Remove(deletUser);
            return deletUser;
        }

       public UserTestDTO UpdateExitUser(int id, UserTestDTO userDTO)
        {
            var user = Villas.FirstOrDefault(u => u.Id == id);
            return user;
        }
    }
}
