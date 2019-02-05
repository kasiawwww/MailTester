using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailTester
{
    public static class MailService
    {
        public static bool Send(MailModel model)
        {
            try
            {
                var message = new MailMessage();
                message.From = new MailAddress(model.FromAddress);
                model.ToAddress.ForEach(m => message.To.Add(new MailAddress(m)));
                message.Subject = model.Subject;
                message.Body = model.Body;
                var smtp = new SmtpClient("smtp.gmail.com");// to app.config
                smtp.UseDefaultCredentials = false;// to app.config
                smtp.Credentials = new NetworkCredential("", "");// to app.config
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(message);
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }


          
        }
    }
}
