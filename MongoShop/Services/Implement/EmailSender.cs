using MongoShop.Services.Interface;
using System.Threading.Tasks;

namespace MongoShop.Services.Impletment;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string message)
    {
        return Task.CompletedTask;
    }
}