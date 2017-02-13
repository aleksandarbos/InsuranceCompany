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
    [Route("api/TravelActivityTravelPurpose")]
    public class TravelActivityTravelPurposeController : Controller
    {
        private readonly ITravelActivityTravelPurposeBLL _travelActivityTravelPurposeBLL;

        public TravelActivityTravelPurposeController(ITravelActivityTravelPurposeBLL travelActivityTravelPurposeBLL)
        {
            _travelActivityTravelPurposeBLL = travelActivityTravelPurposeBLL;
        }

        // GET: api/TravelActivityTravelPurpose
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_travelActivityTravelPurposeBLL.GetAll());
        }

        // GET: api/TravelActivityTravelPurpose/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/TravelActivityTravelPurpose
        [HttpPost]
        public IActionResult Post([FromBody]TravelActivityTravelPurpose value)
        {
            return Json(_travelActivityTravelPurposeBLL.Add(value));
        }

        // PUT: api/TravelActivityTravelPurpose/5
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
