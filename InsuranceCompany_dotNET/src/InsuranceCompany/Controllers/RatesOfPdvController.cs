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
    [Route("api/RatesOfPdv")]
    public class RatesOfPdvController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public RatesOfPdvController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/RatesOfPdv
        [HttpGet]
        public IEnumerable<RateOfPdv> GetRateOfPdv()
        {
            return _context.RateOfPdv;
        }

        // GET: api/RatesOfPdv/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRateOfPdv([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            RateOfPdv rateOfPdv = await _context.RateOfPdv.SingleOrDefaultAsync(m => m.PdvRateId == id);

            if (rateOfPdv == null)
            {
                return NotFound();
            }

            return Ok(rateOfPdv);
        }

        // PUT: api/RatesOfPdv/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRateOfPdv([FromRoute] int id, [FromBody] RateOfPdv rateOfPdv)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rateOfPdv.PdvRateId)
            {
                return BadRequest();
            }

            _context.Entry(rateOfPdv).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RateOfPdvExists(id))
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

        // POST: api/RatesOfPdv
        [HttpPost]
        public async Task<IActionResult> PostRateOfPdv([FromBody] RateOfPdv rateOfPdv)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.RateOfPdv.Add(rateOfPdv);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RateOfPdvExists(rateOfPdv.PdvRateId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRateOfPdv", new { id = rateOfPdv.PdvRateId }, rateOfPdv);
        }

        // DELETE: api/RatesOfPdv/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRateOfPdv([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            RateOfPdv rateOfPdv = await _context.RateOfPdv.SingleOrDefaultAsync(m => m.PdvRateId == id);
            if (rateOfPdv == null)
            {
                return NotFound();
            }

            _context.RateOfPdv.Remove(rateOfPdv);
            await _context.SaveChangesAsync();

            return Ok(rateOfPdv);
        }

        private bool RateOfPdvExists(int id)
        {
            return _context.RateOfPdv.Any(e => e.PdvRateId == id);
        }
    }
}