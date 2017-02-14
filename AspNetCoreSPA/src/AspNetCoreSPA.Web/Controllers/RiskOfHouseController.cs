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
    [Route("api/RiskOfHouse")]
    public class RiskOfHouseController : Controller
    {
        private readonly IRiskOfHouseBLL _riskOfHouseBLL;

        public RiskOfHouseController(IRiskOfHouseBLL riskOfHouseBLL)
        {
            _riskOfHouseBLL = riskOfHouseBLL;
        }

        // GET: api/RiskOfHouse
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_riskOfHouseBLL.GetAll());
        }

        // GET: api/RiskOfHouse/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/RiskOfHouse
        [HttpPost]
        public IActionResult Post([FromBody]RiskOfHouse value)
        {
            return Json(_riskOfHouseBLL.Add(value));
        }

        // PUT: api/RiskOfHouse/5
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
