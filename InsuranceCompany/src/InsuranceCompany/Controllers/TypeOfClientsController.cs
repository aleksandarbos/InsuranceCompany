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
    [Route("api/TypeOfClients")]
    public class TypeOfClientsController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public TypeOfClientsController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/TypeOfClients
        [HttpGet]
        public IEnumerable<TypeOfClient> GetTypeOfClient()
        {
            return _context.TypeOfClient;
        }

        // GET: api/TypeOfClients/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTypeOfClient([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TypeOfClient typeOfClient = await _context.TypeOfClient.SingleOrDefaultAsync(m => m.CtId == id);

            if (typeOfClient == null)
            {
                return NotFound();
            }

            return Ok(typeOfClient);
        }

        // PUT: api/TypeOfClients/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeOfClient([FromRoute] int id, [FromBody] TypeOfClient typeOfClient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != typeOfClient.CtId)
            {
                return BadRequest();
            }

            _context.Entry(typeOfClient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeOfClientExists(id))
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

        // POST: api/TypeOfClients
        [HttpPost]
        public async Task<IActionResult> PostTypeOfClient([FromBody] TypeOfClient typeOfClient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TypeOfClient.Add(typeOfClient);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TypeOfClientExists(typeOfClient.CtId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTypeOfClient", new { id = typeOfClient.CtId }, typeOfClient);
        }

        // DELETE: api/TypeOfClients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeOfClient([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TypeOfClient typeOfClient = await _context.TypeOfClient.SingleOrDefaultAsync(m => m.CtId == id);
            if (typeOfClient == null)
            {
                return NotFound();
            }

            _context.TypeOfClient.Remove(typeOfClient);
            await _context.SaveChangesAsync();

            return Ok(typeOfClient);
        }

        private bool TypeOfClientExists(int id)
        {
            return _context.TypeOfClient.Any(e => e.CtId == id);
        }
    }
}