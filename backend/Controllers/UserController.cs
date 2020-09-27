using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(
            IUserService userService
        )
        {
            this.userService = userService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await userService.Get();
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] User user)
        {
            await userService.Create(user);
        }
    }
}
