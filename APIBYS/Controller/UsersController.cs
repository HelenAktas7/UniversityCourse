using Business.Abstract;
using Business.Concreate;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace APIBYS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        public UsersController()
        {
            _userService = new UserManager();
        }

        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost]
        public User Post([FromBody] User user)
        {
            return _userService.CreateUser(user);
        }

        [HttpPut]
        public User Put([FromBody] User user)
        {
            return _userService.UpdateUser(user);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.DeleteUser(id);
        }
    }
}
