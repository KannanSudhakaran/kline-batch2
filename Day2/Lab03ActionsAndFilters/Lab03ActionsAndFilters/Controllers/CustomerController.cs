using Lab03ActionsAndFilters.Model;
using Microsoft.AspNetCore.Mvc;

namespace Lab03ActionsAndFilters.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var c1 =  new Customer
            {
                Id = 1,
                Name = "Ping HUi",
                City = "Singapore "
            };
            return View(c1);
        }
    }
}
