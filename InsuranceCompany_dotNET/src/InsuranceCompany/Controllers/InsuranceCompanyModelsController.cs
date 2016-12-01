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
    [Route("api/InsuranceCompanyModels")]
    public class InsuranceCompanyModelsController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public InsuranceCompanyModelsController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/InsuranceCompanyModels
        [HttpGet]
        public IEnumerable<InsuranceCompanyModel> GetInsuranceCompany()
        {
            return _context.InsuranceCompany;
        }

        // GET: api/InsuranceCompanyModels/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInsuranceCompanyModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            InsuranceCompanyModel insuranceCompanyModel = await _context.InsuranceCompany.SingleOrDefaultAsync(m => m.CpId == id);

            if (insuranceCompanyModel == null)
            {
                return NotFound();
            }

            return Ok(insuranceCompanyModel);
        }

        // PUT: api/InsuranceCompanyModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInsuranceCompanyModel([FromRoute] int id, [FromBody] InsuranceCompanyModel insuranceCompanyModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != insuranceCompanyModel.CpId)
            {
                return BadRequest();
            }

            _context.Entry(insuranceCompanyModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InsuranceCompanyModelExists(id))
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

        // POST: api/InsuranceCompanyModels
        [HttpPost]
        public async Task<IActionResult> PostInsuranceCompanyModel([FromBody] InsuranceCompanyModel insuranceCompanyModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.InsuranceCompany.Add(insuranceCompanyModel);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InsuranceCompanyModelExists(insuranceCompanyModel.CpId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInsuranceCompanyModel", new { id = insuranceCompanyModel.CpId }, insuranceCompanyModel);
        }

        // DELETE: api/InsuranceCompanyModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInsuranceCompanyModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            InsuranceCompanyModel insuranceCompanyModel = await _context.InsuranceCompany.SingleOrDefaultAsync(m => m.CpId == id);
            if (insuranceCompanyModel == null)
            {
                return NotFound();
            }

            _context.InsuranceCompany.Remove(insuranceCompanyModel);
            await _context.SaveChangesAsync();

            return Ok(insuranceCompanyModel);
        }

        private bool InsuranceCompanyModelExists(int id)
        {
            return _context.InsuranceCompany.Any(e => e.CpId == id);
        }
    }
}