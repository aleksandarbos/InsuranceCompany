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
    [Route("api/Homes")]
    public class HomesController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public HomesController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/Homes
        [HttpGet]
        public IEnumerable<Home> GetHome()
        {
            return _context.Home;
        }

        // GET: api/Homes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHome([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Home home = await _context.Home.SingleOrDefaultAsync(m => m.HomeId == id);

            if (home == null)
            {
                return NotFound();
            }

            return Ok(home);
        }

        // PUT: api/Homes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHome([FromRoute] int id, [FromBody] Home home)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != home.HomeId)
            {
                return BadRequest();
            }

            _context.Entry(home).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HomeExists(id))
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

        // POST: api/Homes
        [HttpPost]
        public async Task<IActionResult> PostHome([FromBody] Home home)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Home.Add(home);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HomeExists(home.HomeId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHome", new { id = home.HomeId }, home);
        }

        // DELETE: api/Homes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Home home = await _context.Home.SingleOrDefaultAsync(m => m.HomeId == id);
            if (home == null)
            {
                return NotFound();
            }

            _context.Home.Remove(home);
            await _context.SaveChangesAsync();

            return Ok(home);
        }

        private bool HomeExists(int id)
        {
            return _context.Home.Any(e => e.HomeId == id);
        }
    }
}