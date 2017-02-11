using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreSPA.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/AgeGroup")]
    public class AgeGroupController : Controller
    {
        // GET: api/AgeGroup
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AgeGroup/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/AgeGroup
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/AgeGroup/5
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
