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
    [Route("api/ItemsOfPackage")]
    public class ItemsOfPackageController : Controller
    {
        private readonly IItemsOfPackageBLL _itemsOfPackageBLL;

        public ItemsOfPackageController(IItemsOfPackageBLL itemsOfPackageBLL)
        {
            _itemsOfPackageBLL = itemsOfPackageBLL;
        }

        // GET: api/ItemsOfPackage
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_itemsOfPackageBLL.GetAll());
        }

        // GET: api/ItemsOfPackage/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/ItemsOfPackage
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ItemsOfPackage/5
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
