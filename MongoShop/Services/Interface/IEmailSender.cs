using System.Threading.Tasks;

namespace MongoShop.Services.Interface;

public interface IEmailSender
{
    Task SendEmailAsync(string email, string subject, string message);
}