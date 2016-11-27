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
    [Route("api/Risks")]
    public class RisksController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public RisksController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/Risks
        [HttpGet]
        public IEnumerable<Risk> GetRisk()
        {
            return _context.Risk;
        }

        // GET: api/Risks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRisk([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Risk risk = await _context.Risk.SingleOrDefaultAsync(m => m.RtId == id);

            if (risk == null)
            {
                return NotFound();
            }

            return Ok(risk);
        }

        // PUT: api/Risks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRisk([FromRoute] int id, [FromBody] Risk risk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != risk.RtId)
            {
                return BadRequest();
            }

            _context.Entry(risk).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RiskExists(id))
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

        // POST: api/Risks
        [HttpPost]
        public async Task<IActionResult> PostRisk([FromBody] Risk risk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Risk.Add(risk);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RiskExists(risk.RtId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRisk", new { id = risk.RtId }, risk);
        }

        // DELETE: api/Risks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRisk([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Risk risk = await _context.Risk.SingleOrDefaultAsync(m => m.RtId == id);
            if (risk == null)
            {
                return NotFound();
            }

            _context.Risk.Remove(risk);
            await _context.SaveChangesAsync();

            return Ok(risk);
        }

        private bool RiskExists(int id)
        {
            return _context.Risk.Any(e => e.RtId == id);
        }
    }
}