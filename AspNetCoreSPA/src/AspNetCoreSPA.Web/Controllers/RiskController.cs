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
    [Route("api/Risk")]
    public class RiskController : Controller
    {
        private readonly IRiskBLL _riskBLL;

        public RiskController(IRiskBLL riskBLL)
        {
            _riskBLL = riskBLL;
        }

        // GET: api/Risk
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_riskBLL.GetAll());
        }

        // GET: api/Risk/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/Risk
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Risk/5
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
