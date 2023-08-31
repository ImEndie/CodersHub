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
        void UpdateUser(Guid token, User user);
        void DeleteUser(Guid token);
        User GetUser(Guid token);
        List<User> GetUsers();
    }
}
