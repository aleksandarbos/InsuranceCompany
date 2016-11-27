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
    [Route("api/InsuranceCompanies")]
    public class InsuranceCompaniesController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public InsuranceCompaniesController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/InsuranceCompanies
        [HttpGet]
        public IEnumerable<InsuranceCompany> GetInsuranceCompany()
        {
            return _context.InsuranceCompany;
        }

        // GET: api/InsuranceCompanies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInsuranceCompany([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            InsuranceCompany insuranceCompany = await _context.InsuranceCompany.SingleOrDefaultAsync(m => m.CpId == id);

            if (insuranceCompany == null)
            {
                return NotFound();
            }

            return Ok(insuranceCompany);
        }

        // PUT: api/InsuranceCompanies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInsuranceCompany([FromRoute] int id, [FromBody] InsuranceCompany insuranceCompany)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != insuranceCompany.CpId)
            {
                return BadRequest();
            }

            _context.Entry(insuranceCompany).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InsuranceCompanyExists(id))
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

        // POST: api/InsuranceCompanies
        [HttpPost]
        public async Task<IActionResult> PostInsuranceCompany([FromBody] InsuranceCompany insuranceCompany)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.InsuranceCompany.Add(insuranceCompany);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InsuranceCompanyExists(insuranceCompany.CpId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInsuranceCompany", new { id = insuranceCompany.CpId }, insuranceCompany);
        }

        // DELETE: api/InsuranceCompanies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInsuranceCompany([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            InsuranceCompany insuranceCompany = await _context.InsuranceCompany.SingleOrDefaultAsync(m => m.CpId == id);
            if (insuranceCompany == null)
            {
                return NotFound();
            }

            _context.InsuranceCompany.Remove(insuranceCompany);
            await _context.SaveChangesAsync();

            return Ok(insuranceCompany);
        }

        private bool InsuranceCompanyExists(int id)
        {
            return _context.InsuranceCompany.Any(e => e.CpId == id);
        }
    }
}