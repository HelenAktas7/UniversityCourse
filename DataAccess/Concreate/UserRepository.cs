using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    public class UserRepository : IUserRepository
    {
        public User CreateUser(User user)
        {
            using (var userDbContext = new ProjeDbContext())
            {
                userDbContext.Users.Add(user);
                userDbContext.SaveChanges();
                return user;
            }
        }

        public void DeleteUser(int id)
        {
            using (var userDbContext = new ProjeDbContext())
            {
                var deletedUser = GetUserById(id);
                userDbContext.Users.Remove(deletedUser);
                userDbContext.SaveChanges();
            }
        }

        public User GetUserById(int id)
        {
            using (var userDbContext = new ProjeDbContext())
            {
                return userDbContext.Users.Find(id);
            }
        }

        public List<User> GetAllUsers()
        {
            using (var userDbContext = new ProjeDbContext())
            {
                return userDbContext.Users.ToList();
            }
        }

        public User UpdateUser(User user)
        {
            using (var userDbContext = new ProjeDbContext())
            {
                userDbContext.Users.Update(user);
                userDbContext.SaveChanges();
                return user;
            }
        }
    }
}

