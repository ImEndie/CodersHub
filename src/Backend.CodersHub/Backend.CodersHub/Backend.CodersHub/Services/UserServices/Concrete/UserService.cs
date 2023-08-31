using Backend.CodersHub.Files;
using Backend.CodersHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.CodersHub.Services.UserServices.Concrete
{
    public class UserService : IUserService
    {
        private readonly IFileContext _fileContext;

        public UserService()
        {
            _fileContext = new FileContext();
        }

        public Guid AddUser(UserDto userDto)
        {
            var user = new
                User(userDto.FirstName,
                userDto.LastName,
                userDto.Bio,
                userDto.Email,
                userDto.Password);

            return _fileContext.AddUser(user);
        }

        public void DeleteUser(Guid token)
        {
            _fileContext.DeleteUser(token);
        }

        public User GetUser(Guid token)
        {
            return _fileContext.GetUser(token);
        }

        public void UpdateUser(Guid token, User user)
        {
            _fileContext.UpdateUser(token, user);
        }

        public List<User> GetUsers()
        {
            return _fileContext.GetUsers();
        }

    }
}
