

using AspNetCoreSPA.BLL;
using AspNetCoreSPA.Model.POCOs;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Post([FromBody]Car value)
        {
            return Json(_carBLL.Add(value));
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
