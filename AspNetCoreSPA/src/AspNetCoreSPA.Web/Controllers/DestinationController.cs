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
    [Route("api/Destination")]
    public class DestinationController : Controller
    {
        private readonly IDestinationBLL _destinationBLL;

        public DestinationController(IDestinationBLL destinationBLL)
        {
            _destinationBLL = destinationBLL;
        }

        // GET: api/Destination
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_destinationBLL.GetAll());
        }

        // GET: api/Destination/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/Destination
        [HttpPost]
        public IActionResult Post([FromBody]Destination value)
        {
            return Json(_destinationBLL.Add(value));
        }

        // PUT: api/Destination/5
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
