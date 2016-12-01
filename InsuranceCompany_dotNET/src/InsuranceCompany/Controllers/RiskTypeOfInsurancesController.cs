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
    [Route("api/RiskTypeOfInsurances")]
    public class RiskTypeOfInsurancesController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public RiskTypeOfInsurancesController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/RiskTypeOfInsurances
        [HttpGet]
        public IEnumerable<RiskTypeOfInsurance> GetRiskTypeOfInsurance()
        {
            return _context.RiskTypeOfInsurance;
        }

        // GET: api/RiskTypeOfInsurances/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRiskTypeOfInsurance([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            RiskTypeOfInsurance riskTypeOfInsurance = await _context.RiskTypeOfInsurance.SingleOrDefaultAsync(m => m.RtId == id);

            if (riskTypeOfInsurance == null)
            {
                return NotFound();
            }

            return Ok(riskTypeOfInsurance);
        }

        // PUT: api/RiskTypeOfInsurances/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRiskTypeOfInsurance([FromRoute] int id, [FromBody] RiskTypeOfInsurance riskTypeOfInsurance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != riskTypeOfInsurance.RtId)
            {
                return BadRequest();
            }

            _context.Entry(riskTypeOfInsurance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RiskTypeOfInsuranceExists(id))
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

        // POST: api/RiskTypeOfInsurances
        [HttpPost]
        public async Task<IActionResult> PostRiskTypeOfInsurance([FromBody] RiskTypeOfInsurance riskTypeOfInsurance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.RiskTypeOfInsurance.Add(riskTypeOfInsurance);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RiskTypeOfInsuranceExists(riskTypeOfInsurance.RtId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRiskTypeOfInsurance", new { id = riskTypeOfInsurance.RtId }, riskTypeOfInsurance);
        }

        // DELETE: api/RiskTypeOfInsurances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRiskTypeOfInsurance([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            RiskTypeOfInsurance riskTypeOfInsurance = await _context.RiskTypeOfInsurance.SingleOrDefaultAsync(m => m.RtId == id);
            if (riskTypeOfInsurance == null)
            {
                return NotFound();
            }

            _context.RiskTypeOfInsurance.Remove(riskTypeOfInsurance);
            await _context.SaveChangesAsync();

            return Ok(riskTypeOfInsurance);
        }

        private bool RiskTypeOfInsuranceExists(int id)
        {
            return _context.RiskTypeOfInsurance.Any(e => e.RtId == id);
        }
    }
}