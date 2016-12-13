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
    [Route("api/SubjectOfInsurances")]
    public class SubjectOfInsurancesController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public SubjectOfInsurancesController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/SubjectOfInsurances
        [HttpGet]
        public IEnumerable<SubjectOfInsurance> GetSubjectOfInsurance()
        {
            return _context.SubjectOfInsurance;
        }

        // GET: api/SubjectOfInsurances/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubjectOfInsurance([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            SubjectOfInsurance subjectOfInsurance = await _context.SubjectOfInsurance.SingleOrDefaultAsync(m => m.IiId == id);

            if (subjectOfInsurance == null)
            {
                return NotFound();
            }

            return Ok(subjectOfInsurance);
        }

        // PUT: api/SubjectOfInsurances/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubjectOfInsurance([FromRoute] int id, [FromBody] SubjectOfInsurance subjectOfInsurance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != subjectOfInsurance.IiId)
            {
                return BadRequest();
            }

            _context.Entry(subjectOfInsurance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubjectOfInsuranceExists(id))
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

        // POST: api/SubjectOfInsurances
        [HttpPost]
        public async Task<IActionResult> PostSubjectOfInsurance([FromBody] SubjectOfInsurance subjectOfInsurance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SubjectOfInsurance.Add(subjectOfInsurance);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SubjectOfInsuranceExists(subjectOfInsurance.IiId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSubjectOfInsurance", new { id = subjectOfInsurance.IiId }, subjectOfInsurance);
        }

        // DELETE: api/SubjectOfInsurances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubjectOfInsurance([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            SubjectOfInsurance subjectOfInsurance = await _context.SubjectOfInsurance.SingleOrDefaultAsync(m => m.IiId == id);
            if (subjectOfInsurance == null)
            {
                return NotFound();
            }

            _context.SubjectOfInsurance.Remove(subjectOfInsurance);
            await _context.SaveChangesAsync();

            return Ok(subjectOfInsurance);
        }

        private bool SubjectOfInsuranceExists(int id)
        {
            return _context.SubjectOfInsurance.Any(e => e.IiId == id);
        }
    }
}