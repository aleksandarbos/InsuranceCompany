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
    [Route("api/TravelPurpose")]
    public class TravelPurposeController : Controller
    {
        private readonly ITravelPurposeBLL _travelPurposeBLL;

        public TravelPurposeController(ITravelPurposeBLL travelPurposeBLL)
        {
            _travelPurposeBLL = travelPurposeBLL;
        }

        // GET: api/TravelPurpose
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_travelPurposeBLL.GetAll());
        }

        // GET: api/TravelPurpose/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/TravelPurpose
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TravelPurpose/5
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
