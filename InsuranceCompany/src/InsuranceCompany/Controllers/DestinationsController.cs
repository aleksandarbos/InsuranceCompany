using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InsuranceCompany.Models;

namespace InsuranceCompany.Controllers
{
    [Produces("application/json")]
    [Route("api/Destinations")]
    public class DestinationsController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public DestinationsController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/Destinations
        [HttpGet]
        public IEnumerable<Destination> GetDestination()
        {
            return _context.Destination;
        }

        // GET: api/Destinations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDestination([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Destination destination = await _context.Destination.SingleOrDefaultAsync(m => m.DstId == id);

            if (destination == null)
            {
                return NotFound();
            }

            return Ok(destination);
        }

        // PUT: api/Destinations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDestination([FromRoute] int id, [FromBody] Destination destination)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != destination.DstId)
            {
                return BadRequest();
            }

            _context.Entry(destination).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinationExists(id))
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

        // POST: api/Destinations
        [HttpPost]
        public async Task<IActionResult> PostDestination([FromBody] Destination destination)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Destination.Add(destination);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DestinationExists(destination.DstId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDestination", new { id = destination.DstId }, destination);
        }

        // DELETE: api/Destinations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestination([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Destination destination = await _context.Destination.SingleOrDefaultAsync(m => m.DstId == id);
            if (destination == null)
            {
                return NotFound();
            }

            _context.Destination.Remove(destination);
            await _context.SaveChangesAsync();

            return Ok(destination);
        }

        private bool DestinationExists(int id)
        {
            return _context.Destination.Any(e => e.DstId == id);
        }
    }
}