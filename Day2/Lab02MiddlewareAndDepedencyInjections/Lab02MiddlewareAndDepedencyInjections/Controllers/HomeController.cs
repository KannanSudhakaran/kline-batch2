using Lab02MiddlewareAndDepedencyInjections.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Lab02MiddlewareAndDepedencyInjections.Controllers
{
    public class HomeController : Controller
    {

        private IEmailService _emailService;

        public HomeController(IEmailService emailService) {
            _emailService = emailService;
            Console.WriteLine("Home controller created");
        }
        public async Task<IActionResult> Index() {

            await _emailService.SendEmailAsync("contraller@admin", "ctonroller");
            return Content("<h1>Index view of home controller</h1>","text/html");

        
        }
    }
}
