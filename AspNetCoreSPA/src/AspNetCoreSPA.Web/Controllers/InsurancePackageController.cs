using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreSPA.BLL;

namespace AspNetCoreSPA.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/InsurancePackage")]
    public class InsurancePackageController : Controller
    {
        private readonly IInsurancePackageBLL _insurancePackageBLL;

        public InsurancePackageController(IInsurancePackageBLL insurancePackageBLL)
        {
            _insurancePackageBLL = insurancePackageBLL;
        }

        // GET: api/InsurancePackage
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_insurancePackageBLL.GetAll());
        }

        // GET: api/InsurancePackage/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/InsurancePackage
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/InsurancePackage/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
