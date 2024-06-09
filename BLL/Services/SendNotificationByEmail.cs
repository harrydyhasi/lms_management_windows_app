using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class SendNotificationByEmail
    {
        private static SendNotificationByEmail instance;
        private string fromMail = "talemy908@gmail.com";
        private string fromPassword = "wpfzkksvvwxiypji";
        MailMessage message;

        public SendNotificationByEmail()
        {
            message = new MailMessage();
        }

        public static SendNotificationByEmail Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SendNotificationByEmail();
                }
                return SendNotificationByEmail.instance;
            }

            private set
            {
                SendNotificationByEmail.instance = value;
            }
        }

        public void SendEmail(string receiver, string subject, string body)
        {
            message.From = new MailAddress(fromMail);
            message.Subject = subject;
            message.To.Add(new MailAddress(receiver));
            message.Body = body;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }




    }
}
