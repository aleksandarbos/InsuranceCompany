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
    [Route("api/PricelistItem")]
    public class PricelistItemController : Controller
    {
        /*private readonly IPricelistItemBLL _pricelistItemBLL;*/

        public PricelistItemController(/*IPricelistItemBLL pricelistItemBLL*/)
        {
            //_pricelistItemBLL = pricelistItemBLL;
        }

        // GET: api/PricelistItem
        [HttpGet]
        public IActionResult Get()
        {
            return Json(/*_pricelistItemBLL.GetAll()*/"");
        }

        // GET: api/PricelistItem/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/PricelistItem
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PricelistItem/5
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
