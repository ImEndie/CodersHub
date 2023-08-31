using Backend.CodersHub.Files;
using Backend.CodersHub.Models;
using Backend.CodersHub.Services;
using Backend.CodersHub.Services.UserServices;
using Backend.CodersHub.Services.UserServices.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CodersHub.Api.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        [HttpPost("user")]
        public Guid AddUser([FromBody] UserDto user)
        {
            return _userService.AddUser(user);
        }

        [HttpPut("token, user")]
        public void UpdateUser([FromBody] Guid token, User user)
        {
            _userService.UpdateUser(token, user);
        }

        [HttpDelete("token")]
        public void DeleteUser([FromBody] Guid token)
        {
            _userService.DeleteUser(token);
        }

        [HttpGet("token")]
        public User GetUser([FromBody] Guid token)
        {
            return _userService.GetUser(token);
        }

        [HttpGet]
        public List<User> GetUsers()
        {
            return _userService.GetUsers();
        }
    }
}
