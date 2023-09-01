using Backend.CodersHub.Files;
using Backend.CodersHub.Models;
using Backend.CodersHub.Services;
using Backend.CodersHub.Services.UserServices;
using Backend.CodersHub.Services.UserServices.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CodersHub.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        [HttpPost("user")]
        public Guid AddUser(UserDto user)
        {
            return _userService.Add(user);
        }

        [HttpPost("token, user")]
        public void UpdateUser(Guid token, string currentPassword, UserDto userDto)
        {
            _userService.Update(token, currentPassword, userDto);
        }

        [HttpDelete("token")]
        public void DeleteUser(Guid token)
        {
            _userService.Delete(token);
        }

        [HttpGet("token")]
        public User GetUser(Guid token)
        {
            return _userService.Get(token);
        }

        [HttpGet]
        public List<User> GetUsers()
        {
            return _userService.GetUsers();
        }
    }
}
