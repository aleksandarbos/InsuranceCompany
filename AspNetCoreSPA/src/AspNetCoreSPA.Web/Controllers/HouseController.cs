using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreSPA.BLL;
using AspNetCoreSPA.Model.POCOs;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreSPA.Web.Controllers
{

    [Produces("application/json")]
    [Route("api/House")]
    public class HouseController : Controller
    {

        private readonly IHomeBLL _homeBLL;

        public HouseController(IHomeBLL homeBLL)
        {
            _homeBLL = homeBLL;
        }

        // GET: api/Home
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_homeBLL.GetAll());
        }

        // GET: api/Home/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/Home
        [HttpPost]
        public IActionResult Post([FromBody]Home value)
        {
            return Json(_homeBLL.Add(value));
        }

        // PUT: api/Home/5
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
