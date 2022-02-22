using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace BiciShop.Models
{
    public class GmailManager
    {
        public static void Send(string messageText, string email)
        {

            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress("my.itstep.service@gmail.com");
            message.To.Add(new MailAddress(email));
            message.Subject = "Info about ordered bicicleta";

            message.IsBodyHtml = true;
            message.Body = messageText;
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("my.itstep.service@gmail.com", "84l56SCp");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }
    }
}
