using AspProjekat.Application.Email;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace AspProjekat.Implementation.Email
{
    public class SmtpEmailSender : IEmailSender
    {

        public void Send(SendEmailDto dto)
        {
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("aspa73432@gmail.com", "Asp123456")
            };

            var message = new MailMessage("aspa73432@gmail.com", dto.SendTo);
            message.Subject = dto.Subject;
            message.Body = dto.Content;
            message.IsBodyHtml = true;
            smtp.Send(message);
        }
    }
}
