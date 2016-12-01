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
    [Route("api/StateOfOrigins")]
    public class StateOfOriginsController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public StateOfOriginsController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/StateOfOrigins
        [HttpGet]
        public IEnumerable<StateOfOrigin> GetStateOfOrigin()
        {
            return _context.StateOfOrigin;
        }

        // GET: api/StateOfOrigins/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStateOfOrigin([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            StateOfOrigin stateOfOrigin = await _context.StateOfOrigin.SingleOrDefaultAsync(m => m.StId == id);

            if (stateOfOrigin == null)
            {
                return NotFound();
            }

            return Ok(stateOfOrigin);
        }

        // PUT: api/StateOfOrigins/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStateOfOrigin([FromRoute] int id, [FromBody] StateOfOrigin stateOfOrigin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != stateOfOrigin.StId)
            {
                return BadRequest();
            }

            _context.Entry(stateOfOrigin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StateOfOriginExists(id))
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

        // POST: api/StateOfOrigins
        [HttpPost]
        public async Task<IActionResult> PostStateOfOrigin([FromBody] StateOfOrigin stateOfOrigin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.StateOfOrigin.Add(stateOfOrigin);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StateOfOriginExists(stateOfOrigin.StId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStateOfOrigin", new { id = stateOfOrigin.StId }, stateOfOrigin);
        }

        // DELETE: api/StateOfOrigins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStateOfOrigin([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            StateOfOrigin stateOfOrigin = await _context.StateOfOrigin.SingleOrDefaultAsync(m => m.StId == id);
            if (stateOfOrigin == null)
            {
                return NotFound();
            }

            _context.StateOfOrigin.Remove(stateOfOrigin);
            await _context.SaveChangesAsync();

            return Ok(stateOfOrigin);
        }

        private bool StateOfOriginExists(int id)
        {
            return _context.StateOfOrigin.Any(e => e.StId == id);
        }
    }
}