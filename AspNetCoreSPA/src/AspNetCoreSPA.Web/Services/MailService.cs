using AspNetCoreSPA.Web.Services.Interfaces;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using AspNetCoreSPA.Web.Configurations;

namespace AspNetCoreSPA.Web.Services
{
    public class MailService : IMailService
    {
        /// <summary>
        /// TODO: Change mail account credentials.
        /// </summary>
        private readonly string EMAIL_UNAME = "violeta.vns@gmail.com";
        private readonly string EMAIL_PWD = "trecasreca23";
        
        public void SendEmail(string email, string subject, string message)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(email);

            mail.From = new MailAddress(EMAIL_UNAME);
            mail.Subject = subject;

            string Body = message;
            mail.Body = Body;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new NetworkCredential(EMAIL_UNAME, EMAIL_PWD);

            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(mail);
        }
    }
}
