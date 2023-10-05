using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AwidServer.Contexts;
using AwidServer.Models;
using Microsoft.EntityFrameworkCore;

namespace AwidServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        Contexts.AwidContext _dbContext;
        public UserController(Contexts.AwidContext dbContext)
        {
            this._dbContext = dbContext;
        }

        // Get : api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            if (this._dbContext.users == null)
                return NotFound();
            return await this._dbContext.users.ToListAsync();
        }

        // Get : api/User/4
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(string id)
        {
            if (this._dbContext.users == null)
                return NotFound();

            var user = await _dbContext.users.FindAsync(id);

            if (user == null)
                return NotFound();

            return user;
        }

        // Post : api/User
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User newUser)
        {
            _dbContext.users.Add(newUser);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = newUser.Id }, newUser);
        }
    }
}
