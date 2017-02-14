using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreSPA.BLL;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Policy")]
    public class PolicyController : Controller
    {
        private readonly IPolicyBLL _policyBLL;

        public PolicyController(IPolicyBLL policyBLL)
        {
            _policyBLL = policyBLL;
        }

        // GET: api/Policy
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_policyBLL.GetAll());
        }

        // GET: api/Policy/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/Policy
        [HttpPost]
        public IActionResult Post([FromBody]Policy polisa)
        {
            return Json(_policyBLL.Add(polisa));
        }

        // PUT: api/Policy/5
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
