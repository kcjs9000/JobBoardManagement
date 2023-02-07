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
    public class usersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public usersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Getusers()
        {
            var userss = await _unitOfWork.users.GetAll(includes: q => q.Include(x => x.UserAppication));
            return Ok(userss);
        }

        // GET: api/users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Getuser(int id)
        {
            var users = await _unitOfWork.users.Get(q => q.Id == id);

            if (users == null)
            {
                return NotFound();
            }

            return users;
        }

        // PUT: api/users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putuser(int id, User users)
        {
            if (id != users.Id)
            {
                return BadRequest();
            }

            _unitOfWork.users.Update(users);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await userExists(id))
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

        // POST: api/users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> Postuser(User users)
        {
            await _unitOfWork.users.Insert(users);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("Getuser", new { id = users.Id }, users);
        }

        // DELETE: api/users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteuser(int id)
        {
            var users = await _unitOfWork.users.Get(q => q.Id == id);
            if (users == null)
            {
                return NotFound();
            }

            await _unitOfWork.users.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> userExists(int id)
        {
            var users = await _unitOfWork.users.Get(q => q.Id == id);
            return users != null;
        }
    }
}
