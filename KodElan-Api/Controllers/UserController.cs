using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KodElan_Api.Abstractions;
using KodElan_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KodElan_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public List<User> GetAll()
        {
            var users = userRepository.GetAll();
            return users;
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = userRepository.Get(id);
            return user;
        }

        [HttpPost]
        public void Create(User user)
        {
            userRepository.Create(user);
        }

        [HttpPost("{id}")]
        public void Edit(User user)
        {
            userRepository.Edit(user);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            userRepository.Delete(id);
        }
    }
}
