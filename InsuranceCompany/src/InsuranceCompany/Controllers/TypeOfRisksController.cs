using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InsuranceCompany.Models;
using Microsoft.AspNetCore.Cors;

namespace InsuranceCompany.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [Produces("application/json")]
    [Route("api/TypeOfRisks")]
    public class TypeOfRisksController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public TypeOfRisksController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/TypeOfRisks
        [HttpGet]
        public IEnumerable<TypeOfRisk> GetTypeOfRisk()
        {
            return _context.TypeOfRisk;
        }

        // GET: api/TypeOfRisks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTypeOfRisk([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TypeOfRisk typeOfRisk = await _context.TypeOfRisk.SingleOrDefaultAsync(m => m.IdType == id);

            if (typeOfRisk == null)
            {
                return NotFound();
            }

            return Ok(typeOfRisk);
        }

        // PUT: api/TypeOfRisks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeOfRisk([FromRoute] int id, [FromBody] TypeOfRisk typeOfRisk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != typeOfRisk.IdType)
            {
                return BadRequest();
            }

            _context.Entry(typeOfRisk).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeOfRiskExists(id))
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

        // POST: api/TypeOfRisks
        [HttpPost]
        public async Task<IActionResult> PostTypeOfRisk([FromBody] TypeOfRisk typeOfRisk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TypeOfRisk.Add(typeOfRisk);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TypeOfRiskExists(typeOfRisk.IdType))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTypeOfRisk", new { id = typeOfRisk.IdType }, typeOfRisk);
        }

        // DELETE: api/TypeOfRisks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeOfRisk([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TypeOfRisk typeOfRisk = await _context.TypeOfRisk.SingleOrDefaultAsync(m => m.IdType == id);
            if (typeOfRisk == null)
            {
                return NotFound();
            }

            _context.TypeOfRisk.Remove(typeOfRisk);
            await _context.SaveChangesAsync();

            return Ok(typeOfRisk);
        }

        private bool TypeOfRiskExists(int id)
        {
            return _context.TypeOfRisk.Any(e => e.IdType == id);
        }
    }
}