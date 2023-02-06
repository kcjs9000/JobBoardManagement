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
    public class EmployersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Employers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employer>>> GetEmployers()
        {
            var employers = await _unitOfWork.Employers.GetAll(includes: q => q.Include(x => x.JobDetail));
            return Ok(employers);
        }

        // GET: api/Employers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employer>> GetEmployer(int id)
        {
            var employer = await _unitOfWork.Employers.Get(q => q.Id == id);

            if (employer == null)
            {
                return NotFound();
            }

            return employer;
        }

        // PUT: api/Employers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployer(int id, Employer employer)
        {
            if (id != employer.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Employers.Update(employer);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await EmployerExists(id))
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

        // POST: api/Employers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employer>> PostEmployer(Employer employer)
        {
            await _unitOfWork.Employers.Insert(employer);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetEmployer", new { id = employer.Id }, employer);
        }

        // DELETE: api/Employers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployer(int id)
        {
            var employer = await _unitOfWork.Employers.Get(q => q.Id == id);
            if (employer == null)
            {
                return NotFound();
            }

            await _unitOfWork.Employers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> EmployerExists(int id)
        {
            var employer = await _unitOfWork.Employers.Get(q => q.Id == id);
            return employer != null;
        }
    }
}