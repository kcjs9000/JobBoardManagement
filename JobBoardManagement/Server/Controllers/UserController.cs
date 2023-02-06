using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JobBoardManagement.Server.Data;
using JobBoardManagement.Shared.Domain;
using JobBoardManagement.Server.IRepository;

namespace JobBoardManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitofWork;

       // public UserController(ApplicationDbContext context)
       public UserController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitofWork = unitOfWork;
        }

        // GET: api/User
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        public async Task<IActionResult> GetUsers()
        {
            //return await _context.Users.ToListAsync();
            var Users = await _unitofWork.users.GetAll();
            return Ok(Users);
        }

        // GET: api/User/5
        [HttpGet("{id}")]
       // public async Task<ActionResult<User>> GetUser(int id)
       public async Task<IActionResult> GetUser(int id)
        {
            //var User = await _context.Users.FindAsync(id);
            var User = await _unitofWork.users.Get(q => q.Id == id);

            if (User == null)
            {
                return NotFound();
            }

            return Ok(User);
        }

        // PUT: api/User/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User User)
        {
            if (id != User.Id)
            {
                return BadRequest();
            }

            //_context.Entry(User).State = EntityState.Modified;
            _unitofWork.users.Update(User);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitofWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
               // if (!UserExists(id))
               if(!await UserExists(id))
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

        // POST: api/User
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User User)
        {
            //_context.Users.Add(User);
            //await _context.SaveChangesAsync();
            await _unitofWork.users.Insert(User);
            await _unitofWork.Save(HttpContext);


            return CreatedAtAction("GetUser", new { id = User.Id }, User);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            //var User = await _context.Users.FindAsync(id);
            var User = await _unitofWork.users.Get(q => q.Id == id);
            if (User == null)
            {
                return NotFound();
            }

            //_context.Users.Remove(User);
            //await _context.SaveChangesAsync();
            await _unitofWork.users.Delete(id);
            await _unitofWork.Save(HttpContext);

            return NoContent();
        }

        //private bool UserExists(int id)
        private async Task<bool> UserExists(int id)
        {
            //return _context.Users.Any(e => e.Id == id);
            var User = await _unitofWork.users.Get(q => q.Id == id);
            return User != null;
        }
    }
}
