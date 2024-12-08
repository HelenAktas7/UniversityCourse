using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    // Bu servisleri yazma amacımız iş kurallarını belirtebilmek!
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;
        public UserManager()
        {
            _userRepository = new UserRepository();
        }
        public User CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }

        public User GetUserById(int id)
        {
            if (id > 0)
            {
                return _userRepository.GetUserById(id);
            }
            throw new Exception("id 0'dan küçük olamaz");
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}

