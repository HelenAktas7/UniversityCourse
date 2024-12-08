using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserRepository
    {
        List<User> GetAllUsers(); // Liste türünde User döndürecek

        User GetUserById(int id); // Tek bir User döndürme

        User CreateUser(User user); // User ekleme

        User UpdateUser(User user); // User güncelleme

        void DeleteUser(int id); // User silme
    }
}

