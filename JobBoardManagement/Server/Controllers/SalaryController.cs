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
    public class SalarysController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SalarysController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Salarys
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Salary>>> GetSalarys()
        {
            var salarys = await _unitOfWork.Salarys.GetAll();
            return Ok(salarys);
        }

        // GET: api/Salarys/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Salary>> GetSalary(int id)
        {
            var salary = await _unitOfWork.Salarys.Get(q => q.Id == id);

            if (salary == null)
            {
                return NotFound();
            }

            return salary;
        }

        // PUT: api/Salarys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalary(int id, Salary salary)
        {
            if (id != salary.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Salarys.Update(salary);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SalaryExists(id))
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

        // POST: api/Salarys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Salary>> PostSalary(Salary salary)
        {
            await _unitOfWork.Salarys.Insert(salary);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSalary", new { id = salary.Id }, salary);
        }

        // DELETE: api/Salarys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalary(int id)
        {
            var salary = await _unitOfWork.Salarys.Get(q => q.Id == id);
            if (salary == null)
            {
                return NotFound();
            }

            await _unitOfWork.Salarys.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> SalaryExists(int id)
        {
            var salary = await _unitOfWork.Salarys.Get(q => q.Id == id);
            return salary != null;
        }
    }
}