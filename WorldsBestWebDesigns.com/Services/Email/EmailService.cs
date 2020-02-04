using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using WorldsBestWebDesigns.com.Interfaces.Email;

namespace WorldsBestWebDesigns.com.Services.Email
{
    public class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class EmailMessage
    {
        public EmailMessage()
        {
            ToAddresses = new List<EmailAddress>();
            FromAddresses = new List<EmailAddress>();
        }

        public List<EmailAddress> ToAddresses { get; set; }
        public List<EmailAddress> FromAddresses { get; set; }
        public string Subject { get; set; }
        public string BodyHtml { get; set; }
        public string BodyText { get; set; }
    }

    public class EmailConfiguration : IEmailConfiguration
    {
        public string SmtpServer { get; } = ConfigurationManager.AppSettings["EmailServer"];
        public int SmtpPort { get; } = 25;
        public string SmtpUsername { get; } = ConfigurationManager.AppSettings["EmailUser"];
        public string SmtpPassword { get; } = ConfigurationManager.AppSettings["EmailPassword"];

        public string PopServer { get; set; }
        public int PopPort { get; set; }
        public string PopUsername { get; set; }
        public string PopPassword { get; set; }
    }

    public class EmailService : IEmailService
    {
        private readonly IEmailConfiguration _emailConfiguration;

        public EmailService(IEmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }

        public List<EmailMessage> ReceiveEmail(int maxCount = 10)
        {
            throw new NotImplementedException();
        }

        public bool Send(EmailMessage emailMessage)
        {
            try
            {
                var message = new MimeMessage();
                message.To.AddRange(emailMessage.ToAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
                message.From.AddRange(emailMessage.FromAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
                message.Subject = emailMessage.Subject;
                message.Body = new TextPart(TextFormat.Text) { Text = emailMessage.BodyText ?? "" };
                message.Body = new TextPart(TextFormat.Html) { Text = emailMessage.BodyHtml ?? "" };

                using (var emailClient = new SmtpClient())
                {
                    emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, SecureSocketOptions.Auto);
                    emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
                    emailClient.Authenticate(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);
                    emailClient.Send(message);
                    emailClient.Disconnect(true);
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }

            return true;
        }
    }
}