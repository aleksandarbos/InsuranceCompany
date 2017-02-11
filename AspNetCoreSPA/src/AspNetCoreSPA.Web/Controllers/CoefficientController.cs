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
    [Route("api/Coefficient")]
    public class CoefficientController : Controller
    {
        private readonly ICoefficientBLL _coefficientBLL;

        public CoefficientController(ICoefficientBLL coefficientBLL)
        {
            _coefficientBLL = coefficientBLL;
        }

        // GET: api/Coefficient
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_coefficientBLL.GetAll());
        }

        // GET: api/Coefficient/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }
                
        // POST: api/Coefficient
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Coefficient/5
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
