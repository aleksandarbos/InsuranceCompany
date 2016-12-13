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
    [Route("api/Pdvs")]
    public class PdvsController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public PdvsController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/Pdvs
        [HttpGet]
        public IEnumerable<Pdv> GetPdv()
        {
            return _context.Pdv;
        }

        // GET: api/Pdvs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPdv([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Pdv pdv = await _context.Pdv.SingleOrDefaultAsync(m => m.PdvId == id);

            if (pdv == null)
            {
                return NotFound();
            }

            return Ok(pdv);
        }

        // PUT: api/Pdvs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPdv([FromRoute] int id, [FromBody] Pdv pdv)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pdv.PdvId)
            {
                return BadRequest();
            }

            _context.Entry(pdv).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PdvExists(id))
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

        // POST: api/Pdvs
        [HttpPost]
        public async Task<IActionResult> PostPdv([FromBody] Pdv pdv)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Pdv.Add(pdv);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PdvExists(pdv.PdvId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPdv", new { id = pdv.PdvId }, pdv);
        }

        // DELETE: api/Pdvs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePdv([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Pdv pdv = await _context.Pdv.SingleOrDefaultAsync(m => m.PdvId == id);
            if (pdv == null)
            {
                return NotFound();
            }

            _context.Pdv.Remove(pdv);
            await _context.SaveChangesAsync();

            return Ok(pdv);
        }

        private bool PdvExists(int id)
        {
            return _context.Pdv.Any(e => e.PdvId == id);
        }
    }
}