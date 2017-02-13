using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSPA.Web.Services.Interfaces
{
    public interface IMailService
    {
        void SendEmail(string email, string subject, string message);
    }
}
