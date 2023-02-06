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
    public class AppController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AppController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Applications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Application>>> GetApplications()
        {
            var applications = await _unitOfWork.Applications.GetAll(includes: q => q.Include(x => x.Resume));
            return Ok(applications);
        }

        // GET: api/Applications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Application>> GetApplication(int id)
        {
            var applications = await _unitOfWork.Applications.Get(q => q.Id == id);

            if (applications == null)
            {
                return NotFound();
            }

            return applications;
        }

        // PUT: api/Applications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplication(int id, Application application)
        {
            if (id != application.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Applications.Update(application);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ApplicationExists(id))
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

        // POST: api/Applications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Application>> PostApplication(Application application)
        {
            await _unitOfWork.Applications.Insert(application);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetApplication", new { id = application.Id }, application);
        }

        // DELETE: api/Applications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplication(int id)
        {
            var application = await _unitOfWork.Applications.Get(q => q.Id == id);
            if (application == null)
            {
                return NotFound();
            }

            await _unitOfWork.Applications.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ApplicationExists(int id)
        {
            var application = await _unitOfWork.Applications.Get(q => q.Id == id);
            return application != null;
        }
    }
}
