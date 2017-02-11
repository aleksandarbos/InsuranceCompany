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
    [Route("api/Car")]
    public class CarController : Controller
    {
        private readonly ICarBLL _carBLL;

        public CarController(ICarBLL carBLL)
        {
            _carBLL = carBLL;
        }

        // GET: api/Car
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_carBLL.GetAll());
        }

        // GET: api/Car/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/Car
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Car/5
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
