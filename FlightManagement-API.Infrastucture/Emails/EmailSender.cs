using FlightManagement_API.Application.Common.Interfaces.Emails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Infrastructure.Emails
{
    public class EmailSender : IEmailSender, IDisposable
    {
        private readonly SmtpClient smtpClient;

        public EmailSender(string host, int port, bool enableSsl, NetworkCredential credentials)
        {
            smtpClient = new SmtpClient(host)
            {
                Port = port,
                EnableSsl = enableSsl,
                Credentials = credentials
            };
        }

        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress("flightmanagementapi@gmail.com"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };
            mailMessage.To.Add(to);

            await smtpClient.SendMailAsync(mailMessage);
        }

        public void Dispose()
        {
            smtpClient.Dispose();
        }
    }
}

