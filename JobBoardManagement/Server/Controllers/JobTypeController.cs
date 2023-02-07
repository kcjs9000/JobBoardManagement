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
    public class JobTypesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/JobTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobType>>> GetJobTypes()
        {
            var jobTypes = await _unitOfWork.JobTypes.GetAll();
            return Ok(jobTypes);
        }

        // GET: api/JobTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobType>> GetJobType(int id)
        {
            var jobType = await _unitOfWork.JobTypes.Get(q => q.Id == id);

            if (jobType == null)
            {
                return NotFound();
            }

            return jobType;
        }

        // PUT: api/JobTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobType(int id, JobType jobType)
        {
            if (id != jobType.Id)
            {
                return BadRequest();
            }

            _unitOfWork.JobTypes.Update(jobType);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await JobTypeExists(id))
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

        // POST: api/JobTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JobType>> PostJobType(JobType jobType)
        {
            await _unitOfWork.JobTypes.Insert(jobType);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetJobType", new { id = jobType.Id }, jobType);
        }

        // DELETE: api/JobTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobType(int id)
        {
            var jobType = await _unitOfWork.JobTypes.Get(q => q.Id == id);
            if (jobType == null)
            {
                return NotFound();
            }

            await _unitOfWork.JobTypes.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> JobTypeExists(int id)
        {
            var jobType = await _unitOfWork.JobTypes.Get(q => q.Id == id);
            return jobType != null;
        }
    }
}
