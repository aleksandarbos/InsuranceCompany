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
    [Route("api/Pdv")]
    public class PdvController : Controller
    {
        private readonly IPdvBLL _pdvBLL;

        public PdvController(IPdvBLL pdvBLL)
        {
            _pdvBLL = pdvBLL;
        }

        // GET: api/Pdv
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_pdvBLL.GetAll());
        }

        // GET: api/Pdv/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/Pdv
        [HttpPost]
        public IActionResult Post([FromBody]Pdv value)
        {
            return Json(_pdvBLL.Add(value));
        }

        // PUT: api/Pdv/5
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
