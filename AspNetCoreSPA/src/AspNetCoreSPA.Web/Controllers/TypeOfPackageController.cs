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
    [Route("api/TypeOfPackage")]
    public class TypeOfPackageController : Controller
    {
        private readonly ITypeOfPackageBLL _typeOfPackageBLL;

        public TypeOfPackageController(ITypeOfPackageBLL typeOfPackageBLL)
        {
            _typeOfPackageBLL = typeOfPackageBLL;
        }

        // GET: api/TypeOfPackage
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_typeOfPackageBLL.GetAll());
        }

        // GET: api/TypeOfPackage/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/TypeOfPackage
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TypeOfPackage/5
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
