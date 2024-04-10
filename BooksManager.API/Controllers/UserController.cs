using BaseLibraryData.Entities;
using GerenciadorLivros.API.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorLivros.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UsersDbContext _userContext;
        public UserController(UsersDbContext userContext)
        {
            _userContext = userContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userContext.Users.Where(u => u.IsDeleted is false);
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            var user = _userContext.Users.SingleOrDefault(u => u.Id == id);
            if(user is null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Post(User user)
        {
            _userContext.Users.Add(user);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            var user = _userContext.Users.SingleOrDefault(u => u.Id == id);
            if (user is null)
            {
                return NotFound();
            }

            _userContext.Users.Remove(user);
            return NoContent();
        }
    }
}
