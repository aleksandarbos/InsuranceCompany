using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InsuranceCompany.Models;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;

namespace InsuranceCompany.Controllers
{
    [EnableCors("AllowAngularApp")]
    [Produces("application/json")]
    [Route("api/Banks")]
    public class BanksController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public BanksController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/Banks
        [HttpGet]
        public string GetBank()
        {
            /*return JsonConvert.SerializeObject(new List<Bank> {
                new Bank() {BankId=0, BankName = "Raiffeisen Bank" },
                new Bank() {BankId=1, BankName = "Unicredit Bank" }
            });
            */
            return JsonConvert.SerializeObject(_context.Bank);
        }

        // GET: api/Banks/5
        public async Task<IActionResult> GetBank(int id)
        {
            //TODO: Inspect accessing getbank with url parameters instead of route parameters.

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Bank bank = await _context.Bank.SingleOrDefaultAsync(m => m.BankId == id);

            if (bank == null)
            {
                return NotFound();
            }

            return Ok(bank);
        }

        // PUT: api/Banks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBank([FromRoute] int id, [FromBody] Bank bank)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bank.BankId)
            {
                return BadRequest();
            }

            _context.Entry(bank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankExists(id))
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

        // POST: api/Banks
        [HttpPost]
        public async Task<IActionResult> PostBank([FromBody] Bank bank)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Bank.Add(bank);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BankExists(bank.BankId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBank", new { id = bank.BankId }, bank);
        }

        // DELETE: api/Banks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBank([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Bank bank = await _context.Bank.SingleOrDefaultAsync(m => m.BankId == id);
            if (bank == null)
            {
                return NotFound();
            }

            _context.Bank.Remove(bank);
            await _context.SaveChangesAsync();

            return Ok(bank);
        }

        private bool BankExists(int id)
        {
            return _context.Bank.Any(e => e.BankId == id);
        }
    }
}