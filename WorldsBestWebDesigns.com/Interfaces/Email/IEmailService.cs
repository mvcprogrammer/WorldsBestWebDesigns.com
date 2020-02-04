using System.Collections.Generic;
using WorldsBestWebDesigns.com.Services.Email;

namespace WorldsBestWebDesigns.com.Interfaces.Email
{
    public interface IEmailConfiguration
    {
        string SmtpServer { get; }
        int SmtpPort { get; }
        string SmtpUsername { get; }
        string SmtpPassword { get; }

        string PopServer { get; }
        int PopPort { get; }
        string PopUsername { get; }
        string PopPassword { get; }
    }

    public interface IEmailService
    {
        bool Send(EmailMessage emailMessage);
        List<EmailMessage> ReceiveEmail(int maxCount = 10);
    }
}