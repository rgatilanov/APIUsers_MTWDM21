using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIUsers.Models;

namespace APIUsers.Services
{
    public interface IUserService
    {

        User AddUser(User user);

        List<User> GetUsers();

        void UpdateUser(User user);

        void DeleteUser(int ID);

        User GetUser(int ID);
    }
}
