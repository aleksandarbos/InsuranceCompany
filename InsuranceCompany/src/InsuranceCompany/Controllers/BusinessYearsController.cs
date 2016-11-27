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
    [Route("api/BusinessYears")]
    public class BusinessYearsController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public BusinessYearsController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/BusinessYears
        [HttpGet]
        public IEnumerable<BusinessYear> GetBusinessYear()
        {
            return _context.BusinessYear;
        }

        // GET: api/BusinessYears/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBusinessYear([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BusinessYear businessYear = await _context.BusinessYear.SingleOrDefaultAsync(m => m.YearId == id);

            if (businessYear == null)
            {
                return NotFound();
            }

            return Ok(businessYear);
        }

        // PUT: api/BusinessYears/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusinessYear([FromRoute] int id, [FromBody] BusinessYear businessYear)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != businessYear.YearId)
            {
                return BadRequest();
            }

            _context.Entry(businessYear).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessYearExists(id))
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

        // POST: api/BusinessYears
        [HttpPost]
        public async Task<IActionResult> PostBusinessYear([FromBody] BusinessYear businessYear)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BusinessYear.Add(businessYear);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BusinessYearExists(businessYear.YearId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBusinessYear", new { id = businessYear.YearId }, businessYear);
        }

        // DELETE: api/BusinessYears/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBusinessYear([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BusinessYear businessYear = await _context.BusinessYear.SingleOrDefaultAsync(m => m.YearId == id);
            if (businessYear == null)
            {
                return NotFound();
            }

            _context.BusinessYear.Remove(businessYear);
            await _context.SaveChangesAsync();

            return Ok(businessYear);
        }

        private bool BusinessYearExists(int id)
        {
            return _context.BusinessYear.Any(e => e.YearId == id);
        }
    }
}