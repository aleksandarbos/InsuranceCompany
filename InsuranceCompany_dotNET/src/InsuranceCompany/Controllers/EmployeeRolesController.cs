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
    [Route("api/EmployeeRoles")]
    public class EmployeeRolesController : Controller
    {
        private readonly InsuranceCompanyContext _context;

        public EmployeeRolesController(InsuranceCompanyContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeRoles
        [HttpGet]
        public IEnumerable<EmployeeRole> GetEmployeeRole()
        {
            return _context.EmployeeRole;
        }

        // GET: api/EmployeeRoles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeRole([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            EmployeeRole employeeRole = await _context.EmployeeRole.SingleOrDefaultAsync(m => m.RoleId == id);

            if (employeeRole == null)
            {
                return NotFound();
            }

            return Ok(employeeRole);
        }

        // PUT: api/EmployeeRoles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeRole([FromRoute] int id, [FromBody] EmployeeRole employeeRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employeeRole.RoleId)
            {
                return BadRequest();
            }

            _context.Entry(employeeRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeRoleExists(id))
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

        // POST: api/EmployeeRoles
        [HttpPost]
        public async Task<IActionResult> PostEmployeeRole([FromBody] EmployeeRole employeeRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.EmployeeRole.Add(employeeRole);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmployeeRoleExists(employeeRole.RoleId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmployeeRole", new { id = employeeRole.RoleId }, employeeRole);
        }

        // DELETE: api/EmployeeRoles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeRole([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            EmployeeRole employeeRole = await _context.EmployeeRole.SingleOrDefaultAsync(m => m.RoleId == id);
            if (employeeRole == null)
            {
                return NotFound();
            }

            _context.EmployeeRole.Remove(employeeRole);
            await _context.SaveChangesAsync();

            return Ok(employeeRole);
        }

        private bool EmployeeRoleExists(int id)
        {
            return _context.EmployeeRole.Any(e => e.RoleId == id);
        }
    }
}