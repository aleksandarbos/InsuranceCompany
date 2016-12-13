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
    [Route("api/Policies")]
    public class PoliciesController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public PoliciesController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/Policies
        [HttpGet]
        public IEnumerable<Policy> GetPolicy()
        {
            return _context.Policy;
        }

        // GET: api/Policies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPolicy([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Policy policy = await _context.Policy.SingleOrDefaultAsync(m => m.PolicyId == id);

            if (policy == null)
            {
                return NotFound();
            }

            return Ok(policy);
        }

        // PUT: api/Policies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPolicy([FromRoute] int id, [FromBody] Policy policy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != policy.PolicyId)
            {
                return BadRequest();
            }

            _context.Entry(policy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PolicyExists(id))
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

        // POST: api/Policies
        [HttpPost]
        public async Task<IActionResult> PostPolicy([FromBody] Policy policy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Policy.Add(policy);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PolicyExists(policy.PolicyId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPolicy", new { id = policy.PolicyId }, policy);
        }

        // DELETE: api/Policies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePolicy([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Policy policy = await _context.Policy.SingleOrDefaultAsync(m => m.PolicyId == id);
            if (policy == null)
            {
                return NotFound();
            }

            _context.Policy.Remove(policy);
            await _context.SaveChangesAsync();

            return Ok(policy);
        }

        private bool PolicyExists(int id)
        {
            return _context.Policy.Any(e => e.PolicyId == id);
        }
    }
}