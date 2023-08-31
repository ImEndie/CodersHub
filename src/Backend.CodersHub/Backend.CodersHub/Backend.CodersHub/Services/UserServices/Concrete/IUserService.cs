using Backend.CodersHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.CodersHub.Services.UserServices.Concrete
{
    public interface IUserService
    {
        Guid AddUser(UserDto userDto);
        void UpdateUser(Guid token,string currentPassword, UserDto userDto);
        void DeleteUser(Guid token);
        User GetUser(Guid token);
        User GetUser(string emailAddress, string password);
        List<User> GetUsers();
    }
}
