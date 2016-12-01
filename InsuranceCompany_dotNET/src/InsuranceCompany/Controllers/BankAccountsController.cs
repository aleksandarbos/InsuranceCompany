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
    [Route("api/BankAccounts")]
    public class BankAccountsController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public BankAccountsController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/BankAccounts
        [HttpGet]
        public IEnumerable<BankAccount> GetBankAccount()
        {
            return _context.BankAccount;
        }

        // GET: api/BankAccounts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBankAccount([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BankAccount bankAccount = await _context.BankAccount.SingleOrDefaultAsync(m => m.Ac1Id == id);

            if (bankAccount == null)
            {
                return NotFound();
            }

            return Ok(bankAccount);
        }

        // PUT: api/BankAccounts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBankAccount([FromRoute] int id, [FromBody] BankAccount bankAccount)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bankAccount.Ac1Id)
            {
                return BadRequest();
            }

            _context.Entry(bankAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankAccountExists(id))
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

        // POST: api/BankAccounts
        [HttpPost]
        public async Task<IActionResult> PostBankAccount([FromBody] BankAccount bankAccount)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BankAccount.Add(bankAccount);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BankAccountExists(bankAccount.Ac1Id))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBankAccount", new { id = bankAccount.Ac1Id }, bankAccount);
        }

        // DELETE: api/BankAccounts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBankAccount([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BankAccount bankAccount = await _context.BankAccount.SingleOrDefaultAsync(m => m.Ac1Id == id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            _context.BankAccount.Remove(bankAccount);
            await _context.SaveChangesAsync();

            return Ok(bankAccount);
        }

        private bool BankAccountExists(int id)
        {
            return _context.BankAccount.Any(e => e.Ac1Id == id);
        }
    }
}