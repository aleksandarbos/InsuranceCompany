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
    [Route("api/RiskOfCar")]
    public class RiskOfCarController : Controller
    {
        private readonly IRiskOfCarBLL _riskOfCarBLL;

        public RiskOfCarController(IRiskOfCarBLL riskOfCarBLL)
        {
            _riskOfCarBLL = riskOfCarBLL;
        }

        // GET: api/RiskOfCar
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_riskOfCarBLL.GetAll());
        }

        // GET: api/RiskOfCar/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/RiskOfCar
        [HttpPost]
        public IActionResult Post([FromBody]RiskOfCar value)
        {
            return Json(_riskOfCarBLL.Add(value));
        }

        // PUT: api/RiskOfCar/5
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
