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
    [Route("api/Pricelists")]
    public class PricelistsController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public PricelistsController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/Pricelists
        [HttpGet]
        public IEnumerable<Pricelist> GetPricelist()
        {
            return _context.Pricelist;
        }

        // GET: api/Pricelists/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPricelist([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Pricelist pricelist = await _context.Pricelist.SingleOrDefaultAsync(m => m.PricelistId == id);

            if (pricelist == null)
            {
                return NotFound();
            }

            return Ok(pricelist);
        }

        // PUT: api/Pricelists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPricelist([FromRoute] int id, [FromBody] Pricelist pricelist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pricelist.PricelistId)
            {
                return BadRequest();
            }

            _context.Entry(pricelist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PricelistExists(id))
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

        // POST: api/Pricelists
        [HttpPost]
        public async Task<IActionResult> PostPricelist([FromBody] Pricelist pricelist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Pricelist.Add(pricelist);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PricelistExists(pricelist.PricelistId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPricelist", new { id = pricelist.PricelistId }, pricelist);
        }

        // DELETE: api/Pricelists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePricelist([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Pricelist pricelist = await _context.Pricelist.SingleOrDefaultAsync(m => m.PricelistId == id);
            if (pricelist == null)
            {
                return NotFound();
            }

            _context.Pricelist.Remove(pricelist);
            await _context.SaveChangesAsync();

            return Ok(pricelist);
        }

        private bool PricelistExists(int id)
        {
            return _context.Pricelist.Any(e => e.PricelistId == id);
        }
    }
}