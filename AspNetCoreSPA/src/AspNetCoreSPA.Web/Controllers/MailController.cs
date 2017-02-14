using System;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreSPA.Web.Services.Interfaces;
using AspNetCoreSPA.Model.POCOs;


namespace AspNetCoreSPA.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Mail")]
    public class MailController : Controller
    {
        private readonly IMailService _mailService;

        public MailController(IMailService mailService)
        {
            _mailService = mailService;
        }

        // POST: api/Mail
        [HttpPost]
        public void Post([FromBody]MailEntity value)
        {
         
            try
            {
                //string email, subject, message;
               _mailService.SendEmail(value.email, value.subject, value.message);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // PUT: api/Mail/5
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
