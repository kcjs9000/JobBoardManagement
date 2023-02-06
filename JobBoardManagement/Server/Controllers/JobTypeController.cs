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
    public class JobTypeController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitofWork;

       // public JobTypeController(ApplicationDbContext context)
       public JobTypeController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitofWork = unitOfWork;
        }

        // GET: api/JobType
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<JobType>>> GetJobTypes()
        public async Task<IActionResult> GetJobTypes()
        {
            //return await _context.JobTypes.ToListAsync();
            var jobTypes = await _unitofWork.JobTypes.GetAll();
            return Ok(jobTypes);
        }

        // GET: api/JobType/5
        [HttpGet("{id}")]
       // public async Task<ActionResult<JobType>> GetJobType(int id)
       public async Task<IActionResult> GetJobType(int id)
        {
            //var JobType = await _context.JobTypes.FindAsync(id);
            var jobType = await _unitofWork.JobTypes.Get(q => q.Id == id);

            if (jobType == null)
            {
                return NotFound();
            }

            return Ok(jobType);
        }

        // PUT: api/JobType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobType(int id, JobType JobType)
        {
            if (id != JobType.Id)
            {
                return BadRequest();
            }

            //_context.Entry(JobType).State = EntityState.Modified;
            _unitofWork.JobTypes.Update(JobType);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitofWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
               // if (!JobTypeExists(id))
               if(!await JobTypeExists(id))
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

        // POST: api/JobType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JobType>> PostJobType(JobType JobType)
        {
            //_context.JobTypes.Add(JobType);
            //await _context.SaveChangesAsync();
            await _unitofWork.JobTypes.Insert(JobType);
            await _unitofWork.Save(HttpContext);


            return CreatedAtAction("GetJobType", new { id = JobType.Id }, JobType);
        }

        // DELETE: api/JobType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobType(int id)
        {
            //var JobType = await _context.JobTypes.FindAsync(id);
            var JobType = await _unitofWork.JobTypes.Get(q => q.Id == id);
            if (JobType == null)
            {
                return NotFound();
            }

            //_context.JobTypes.Remove(JobType);
            //await _context.SaveChangesAsync();
            await _unitofWork.JobTypes.Delete(id);
            await _unitofWork.Save(HttpContext);

            return NoContent();
        }

        //private bool JobTypeExists(int id)
        private async Task<bool> JobTypeExists(int id)
        {
            //return _context.JobTypes.Any(e => e.Id == id);
            var JobType = await _unitofWork.JobTypes.Get(q => q.Id == id);
            return JobType != null;
        }
    }
}
