using System;
using System.Collections.Generic;
using System.Net;
using WorldsBestWebDesigns.com.Interfaces.Email;
using WorldsBestWebDesigns.com.Models;
using WorldsBestWebDesigns.com.Services.Email;

namespace WorldsBestWebDesigns.com.Factories.Email
{
    public static class EmailFactory
    {
        public static IEmailService CreateEmailService() => new EmailService(new EmailConfiguration());

        public static string GetEmailTemplate(ContactRequest contactRequest)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(
                    new Uri($"http://localhost:50008/Contact/ContactResponse?Name={contactRequest.Name}&Email={contactRequest.Email}" +
                    $"&Phone={contactRequest.Phone}&Message={contactRequest.Message}"));
            }
        }

        public static EmailMessage CreateEmailMessageToNeal(ContactRequest contactRequest)
        {
            return new EmailMessage
            {
                FromAddresses = new List<EmailAddress> { new EmailAddress { Address = "neal@mvcprogrammer.com", Name = "Neal Thomas" } },
                ToAddresses = new List<EmailAddress> { new EmailAddress { Address = "mvc.programmer@gmail.com", Name = "Neal Thomas" } },
                Subject = "Request Received",
                BodyHtml = GetEmailTemplate(contactRequest)
            };
        }

        public static EmailMessage CreateEmailMessageToContact(ContactRequest contactRequest)
        {
            return new EmailMessage
            {
                FromAddresses = new List<EmailAddress> { new EmailAddress { Address = "neal@mvcprogrammer.com", Name = "Neal Thomas" } },
                ToAddresses = new List<EmailAddress> { new EmailAddress { Address = contactRequest.Email, Name = contactRequest.Name } },
                Subject = "Request Received",
                BodyText = "Contact Request Received",
                BodyHtml = GetEmailTemplate(contactRequest)
            };
        }
    }
}