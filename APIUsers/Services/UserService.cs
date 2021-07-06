using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIUsers.Models;

namespace APIUsers.Services
{
    public class UserService:IUserService
    {
        public UserContext _userDbContext;
        public UserService(UserContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public User AddUser(User user)
        {
            _userDbContext.Users.Add(user);
            _userDbContext.SaveChanges();
            return user;
        }
        public List<User> GetUsers()
        {
            return _userDbContext.Users.ToList();
        }

        public void UpdateUser(User user)
        {
            _userDbContext.Users.Update(user);
            _userDbContext.SaveChanges();
        }

        public void DeleteUser(int ID)
        {
            var user = _userDbContext.Users.FirstOrDefault(x => x.user_id == ID);
            if (user != null)
            {
                _userDbContext.Remove(user);
                _userDbContext.SaveChanges();
            }
        }

        public User GetUser(int ID)
        {
            return _userDbContext.Users.FirstOrDefault(x => x.user_id == ID);
        }
    }
}
