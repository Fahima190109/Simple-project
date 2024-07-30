using Microsoft.AspNetCore.Mvc;
using Simple_project_using_pattern.Interface;
using Simple_project_using_pattern.Model.DTO;
using Simple_project_using_pattern.Service;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Simple_project_using_pattern.Controller
{
    [Route("Api/UserTest")]
    [ApiController]
    public class UserTestController : ControllerBase
    {
     private readonly IUserTestService _userTestService;
     public UserTestController(IUserTestService userTestService)
        {
            _userTestService = userTestService; 
        }
        [HttpGet]
        public ActionResult<IEnumerable<UserTestDTO>> GetAllUser()
        {
            var user = _userTestService.GetAllUser();
            return Ok(user);

        }

        [HttpGet("{id:int}")]
        public ActionResult<UserTestDTO> GetUserbyId(int id)
        {
           if(id == 0)
            {
                return BadRequest();
            }
            var userId = _userTestService.GetUser(id);
            if (userId == null) 
            { 
                return NotFound();
            }
           return Ok(userId);
        }

        [HttpPost]
        public ActionResult<UserTestDTO>CreateUser([FromBody]UserTestDTO userDTO)
        {
            if(userDTO == null)
            {
                return BadRequest();
            }
            var new_user = _userTestService.CreatNewUser(userDTO);
            if (new_user == null) 
            {
                ModelState.AddModelError("CustomeError", "user already Exists!");
                return BadRequest(ModelState);
            }
            return Ok(new_user); 
        }

        [HttpDelete("{id:int}")]
        public ActionResult<UserTestDTO> UserDelete(int id)
        {
            if (id == 0)
            {
                return null;
            }
            var user_delId = _userTestService.UserDeleteId(id);
            if(user_delId == null)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpPut]
        public ActionResult<UserTestDTO> UpdateUser(int id, [FromBody] UserTestDTO userDTO)
        {
            if (id == null || userDTO == null)
            {
                return BadRequest();
            }
            var update_user = _userTestService. UpdateExitUser(id, userDTO);
            if (update_user == null) {
                return NotFound();
            }
            update_user.Name = userDTO.Name;
            return NoContent();
        }
    }



}

    

