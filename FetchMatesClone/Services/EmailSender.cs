﻿using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace FetchMatesClone.Services
{
    public class EmailSender : IEmailSender
    {
        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
        }

        public AuthMessageSenderOptions Options { get; } //set only via Secret Manager

        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute( email,  subject,  message);
        }       

        public Task Execute( string email, string subject, string message)
        {
            var client = new SendGridClient("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");
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("btwisnewski@outlook.com", "Fetch Mates CEO"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));

            // Disable click tracking.
            // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            msg.SetClickTracking(false, false);

            return client.SendEmailAsync(msg);
        }
    }
}