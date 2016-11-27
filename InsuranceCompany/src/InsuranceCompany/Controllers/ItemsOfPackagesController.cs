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
    [Route("api/ItemsOfPackages")]
    public class ItemsOfPackagesController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public ItemsOfPackagesController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/ItemsOfPackages
        [HttpGet]
        public IEnumerable<ItemsOfPackage> GetItemsOfPackage()
        {
            return _context.ItemsOfPackage;
        }

        // GET: api/ItemsOfPackages/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetItemsOfPackage([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ItemsOfPackage itemsOfPackage = await _context.ItemsOfPackage.SingleOrDefaultAsync(m => m.Id == id);

            if (itemsOfPackage == null)
            {
                return NotFound();
            }

            return Ok(itemsOfPackage);
        }

        // PUT: api/ItemsOfPackages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemsOfPackage([FromRoute] int id, [FromBody] ItemsOfPackage itemsOfPackage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != itemsOfPackage.Id)
            {
                return BadRequest();
            }

            _context.Entry(itemsOfPackage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemsOfPackageExists(id))
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

        // POST: api/ItemsOfPackages
        [HttpPost]
        public async Task<IActionResult> PostItemsOfPackage([FromBody] ItemsOfPackage itemsOfPackage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ItemsOfPackage.Add(itemsOfPackage);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ItemsOfPackageExists(itemsOfPackage.Id))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetItemsOfPackage", new { id = itemsOfPackage.Id }, itemsOfPackage);
        }

        // DELETE: api/ItemsOfPackages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemsOfPackage([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ItemsOfPackage itemsOfPackage = await _context.ItemsOfPackage.SingleOrDefaultAsync(m => m.Id == id);
            if (itemsOfPackage == null)
            {
                return NotFound();
            }

            _context.ItemsOfPackage.Remove(itemsOfPackage);
            await _context.SaveChangesAsync();

            return Ok(itemsOfPackage);
        }

        private bool ItemsOfPackageExists(int id)
        {
            return _context.ItemsOfPackage.Any(e => e.Id == id);
        }
    }
}