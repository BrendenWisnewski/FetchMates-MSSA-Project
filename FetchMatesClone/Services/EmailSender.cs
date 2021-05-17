using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace FetchMatesClone.Services
{
    public class EmailSender : IEmailSender
    {
        private string _theKey = null;
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
                From = new EmailAddress("fetchmatesCEO@gmail.com", "Fetch Mates CEO"),
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
