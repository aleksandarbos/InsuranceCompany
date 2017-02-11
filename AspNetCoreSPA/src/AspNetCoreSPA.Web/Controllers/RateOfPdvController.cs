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
    [Route("api/RateOfPdv")]
    public class RateOfPdvController : Controller
    {
        private readonly IRateOfPdvBLL _rateOfPdvBLL;

        public RateOfPdvController(IRateOfPdvBLL rateOfPdvBLL)
        {
            _rateOfPdvBLL = rateOfPdvBLL;
        }

        // GET: api/RateOfPdv
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_rateOfPdvBLL.GetAll());
        }

        // GET: api/RateOfPdv/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/RateOfPdv
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/RateOfPdv/5
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
