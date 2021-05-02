using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace FetchMatesClone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
                Execute().Wait();
            
        }

        static async Task Execute()
        {
            //var apiKey = Environment.GetEnvironmentVariable("SEND_GRID_KEY");
            var client = new SendGridClient("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");
            var from = new EmailAddress("btwisnewski@outlook.com", "Fetch Mates CEO");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("btwisnewski@gmail.com", "Dog Lover");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
