using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookShopWebAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace BookShopWebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly BookShopDBContext _context;

        public UsersController(BookShopDBContext context)
        {
            _context = context;
        }

        //Get User by email address
        [HttpGet("GetByEmail/{email}")]
        public async Task<ActionResult<IEnumerable<User>>> GetUserByEmail(string email)
        {
            List<User> users = _context.Users.Where(usr => usr.email_address == email).ToList();

            if (users == null)
            {
                return NotFound();
            }

            return users;
        }


        [HttpGet("GetByName/{name}")]
        public async Task<ActionResult<IEnumerable<User>>> GetAuthorByFName(string name)
        {
            List<User> users = _context.Users.Where(auth => auth.FirstName == name).ToList();

            if (users == null)
            {
                return NotFound();
            }

            return users;
        }

        [HttpGet("GetUser")]
        public async Task<ActionResult<User>> GetUser()
        {
            string emailAddress = HttpContext.User.Identity.Name;
            var user = await _context.Users.Where(user => user.email_address == emailAddress).FirstOrDefaultAsync();

            user.Password = null;
            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(string id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(string id, User user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users.Add(user);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserExists(user.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUser", new { id = user.UserId }, user);
        }

        
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(string id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
