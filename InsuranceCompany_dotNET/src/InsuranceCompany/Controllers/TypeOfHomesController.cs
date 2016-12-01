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
    [Route("api/TypeOfHomes")]
    public class TypeOfHomesController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public TypeOfHomesController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/TypeOfHomes
        [HttpGet]
        public IEnumerable<TypeOfHome> GetTypeOfHome()
        {
            return _context.TypeOfHome;
        }

        // GET: api/TypeOfHomes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTypeOfHome([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TypeOfHome typeOfHome = await _context.TypeOfHome.SingleOrDefaultAsync(m => m.HtId == id);

            if (typeOfHome == null)
            {
                return NotFound();
            }

            return Ok(typeOfHome);
        }

        // PUT: api/TypeOfHomes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeOfHome([FromRoute] int id, [FromBody] TypeOfHome typeOfHome)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != typeOfHome.HtId)
            {
                return BadRequest();
            }

            _context.Entry(typeOfHome).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeOfHomeExists(id))
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

        // POST: api/TypeOfHomes
        [HttpPost]
        public async Task<IActionResult> PostTypeOfHome([FromBody] TypeOfHome typeOfHome)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TypeOfHome.Add(typeOfHome);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TypeOfHomeExists(typeOfHome.HtId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTypeOfHome", new { id = typeOfHome.HtId }, typeOfHome);
        }

        // DELETE: api/TypeOfHomes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeOfHome([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TypeOfHome typeOfHome = await _context.TypeOfHome.SingleOrDefaultAsync(m => m.HtId == id);
            if (typeOfHome == null)
            {
                return NotFound();
            }

            _context.TypeOfHome.Remove(typeOfHome);
            await _context.SaveChangesAsync();

            return Ok(typeOfHome);
        }

        private bool TypeOfHomeExists(int id)
        {
            return _context.TypeOfHome.Any(e => e.HtId == id);
        }
    }
}