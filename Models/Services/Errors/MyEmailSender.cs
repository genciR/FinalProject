using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace Smartphone_Shop.Models.Services.Errors
{
    public class MyEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
