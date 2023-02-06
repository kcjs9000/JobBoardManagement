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
    public class JobDetailController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobDetailController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Jobs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobDetail>>> GetJobs()
        {
            var jobdetails = await _unitOfWork.Jobs.GetAll(includes: q => q.Include(x => x.Salary).Include(x => x.JobLocation).Include(x => x.JobCategory).Include(x => x.JobType));
            return Ok(jobdetails);
        }

        // GET: api/Jobs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobDetail>> GetJobDetail(int id)
        {
            var jobdetail = await _unitOfWork.Jobs.Get(q => q.Id == id);

            if (jobdetail == null)
            {
                return NotFound();
            }

            return jobdetail;
        }

        // PUT: api/Jobs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobDetail(int id, JobDetail jobdetail)
        {
            if (id != jobdetail.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Jobs.Update(jobdetail);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await JobDetailExists(id))
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

        // POST: api/Jobs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JobDetail>> PostJobDetail(JobDetail jobdetail)
        {
            await _unitOfWork.Jobs.Insert(jobdetail);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetJobDetail", new { id = jobdetail.Id }, jobdetail);
        }

        // DELETE: api/Jobs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobDetail(int id)
        {
            var jobdetail = await _unitOfWork.Jobs.Get(q => q.Id == id);
            if (jobdetail == null)
            {
                return NotFound();
            }

            await _unitOfWork.Jobs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> JobDetailExists(int id)
        {
            var jobdetail = await _unitOfWork.Jobs.Get(q => q.Id == id);
            return jobdetail != null;
        }
    }
}