using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIUsers.Models;
using APIUsers.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIUsers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        [Route("[action]")]
        //[Route("api/User/GetUsers")]
        public IEnumerable<User> GetUsers()
        {
            return _userService.GetUsers();
        }

        // https://localhost:5001/api/user/getuser?ID= 1
        [HttpGet]
        [Route("GetUser")]
        public User Getuser(int ID)
        {
            return _userService.GetUser(ID);
        }

        // POST api/<UserController>
        [HttpPost]
        [Route("[action]")]
        //[Route("api/User/AddUser")]
        public IActionResult AddUser(User user)
        {
            _userService.AddUser(user);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        //[Route("api/User/UpdateUser")]
        public IActionResult UpdateUser(User user)
        {
            _userService.UpdateUser(user);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        //[Route("api/User/DeleteUser")]
        public IActionResult DeleteUser(int ID)
        {
            var existingUser = _userService.GetUser(ID);
            if (existingUser != null)
            {
                _userService.DeleteUser(existingUser.user_id);
                return Ok();
            }
            return NotFound($"User Not Found with ID : {existingUser.user_id}");
        }
    }
}
