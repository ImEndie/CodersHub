using Backend.CodersHub.Files;
using Backend.CodersHub.Models;
using Backend.CodersHub.Services;
using Backend.CodersHub.Services.UserServices;
using Backend.CodersHub.Services.UserServices.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CodersHub.Api.Controllers
{
    //[ApiController]
    //[Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        [HttpPost("user")]
        public Guid AddUser([FromQuery] UserDto user)
        {
            return _userService.AddUser(user);
        }

        [HttpPost("token, user")]
        public void UpdateUser([FromBody] Guid token, string currentPassword, UserDto userDto)
        {
            _userService.UpdateUser(token, currentPassword, userDto);
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

        [HttpGet("")]
        public List<User> GetUsers()
        {
            return _userService.GetUsers();
        }
    }
}
