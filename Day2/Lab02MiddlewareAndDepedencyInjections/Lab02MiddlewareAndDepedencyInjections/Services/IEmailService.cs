using System.Threading.Tasks;

namespace Lab02MiddlewareAndDepedencyInjections.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email,string subject);
    }
}
