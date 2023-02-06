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
    public class JLocationsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public JLocationsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/JLocations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JLocation>>> GetJLocations()
        {
            var Jlocations = await _unitOfWork.JLocations.GetAll();
            return Ok(Jlocations);
        }

        // GET: api/JLocations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JLocation>> GetJLocation(int id)
        {
            var Jlocation = await _unitOfWork.JLocations.Get(q => q.Id == id);

            if (Jlocation == null)
            {
                return NotFound();
            }

            return Jlocation;
        }

        // PUT: api/JLocations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJLocation(int id, JLocation Jlocation)
        {
            if (id != Jlocation.Id)
            {
                return BadRequest();
            }

            _unitOfWork.JLocations.Update(Jlocation);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await JLocationExists(id))
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

        // POST: api/JLocations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JLocation>> PostJLocation(JLocation Jlocation)
        {
            await _unitOfWork.JLocations.Insert(Jlocation);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetJLocation", new { id = Jlocation.Id }, Jlocation);
        }

        // DELETE: api/JLocations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJLocation(int id)
        {
            var Jlocation = await _unitOfWork.JLocations.Get(q => q.Id == id);
            if (Jlocation == null)
            {
                return NotFound();
            }

            await _unitOfWork.JLocations.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> JLocationExists(int id)
        {
            var Jlocation = await _unitOfWork.JLocations.Get(q => q.Id == id);
            return Jlocation != null;
        }
    }
}
