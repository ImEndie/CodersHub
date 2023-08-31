using Backend.CodersHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.CodersHub.Files
{
    public interface IFileContext
    {
        /// <summary>
        /// User qo'shish
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Qo'shilgan userning tokenini qaytaradi</returns>
        Guid AddUser(User user);

        /// <summary>
        /// token orqali userni olish
        /// </summary>
        User GetUser(Guid token);

        /// <summary>
        /// token orqali topib userni o'chirish
        /// </summary>
        /// <param name="token"></param>
        void DeleteUser(Guid token);

        /// <summary>
        /// Token orqali topilgan userni berilgan user malumotlari bilan update qiladi
        /// </summary>
        /// <param name="token"></param>
        /// <param name="user"></param>
        void UpdateUser(Guid token, User user);
        List<User> GetUsers();
    }
}
