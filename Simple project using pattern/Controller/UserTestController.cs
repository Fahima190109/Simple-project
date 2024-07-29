using Microsoft.AspNetCore.Mvc;
using Simple_project_using_pattern.Interface;
using Simple_project_using_pattern.Model.DTO;
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

    }
}
