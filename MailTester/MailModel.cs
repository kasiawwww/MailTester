using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailTester
{
    public class MailModel
    {
        public MailModel() {
            ToAddress = new List<string>();
        }
        public MailModel ( string fromAdress, List<string> toAddress, string subject = "", string body = "")
        {
            FromAddress = FromAddress;
            ToAddress = toAddress;
            Subject = subject;
            Body = body;
           
        }

        public void SetMailTo(string emails)
        {
            var temp = emails.Split(';');
            ToAddress.AddRange(temp);
            ToAddress.Remove(string.Empty);
        }
        

        public List<string>ToAddress { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
