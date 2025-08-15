using System;
using System.Threading.Tasks;

namespace Lab02MiddlewareAndDepedencyInjections.Services
{
    public class AmazonSES : IEmailService
    {


        public AmazonSES() {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AmazonSES created " + this.GetHashCode());
            Console.ResetColor();


        }
        public Task SendEmailAsync(string email, string subject)
        {
           return Task.Run(() => 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"AmazonSES: Sending email to {email} with subject '{subject}'  {this.GetHashCode()}");
                Console.ResetColor();
            });
        }
    }
}
