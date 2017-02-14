

using AspNetCoreSPA.BLL;
using AspNetCoreSPA.BLL.Interfaces;
using AspNetCoreSPA.Model.POCOs;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreSPA.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Client")]
    public class ClientController : Controller
    {
        private readonly IClientBLL _clientBLL;

        public ClientController(IClientBLL clientBLL)
        {
            _clientBLL = clientBLL;
        }

        // GET: api/Client
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_clientBLL.GetAll());
        }

        // GET: api/Client/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/Client
        [HttpPost]
        public IActionResult Post([FromBody]Client value)
        {

           return Json(_clientBLL.Add(value));
        }
        
        // PUT: api/Client/5
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
