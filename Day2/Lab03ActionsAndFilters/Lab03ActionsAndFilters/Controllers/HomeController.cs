using Lab03ActionsAndFilters.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab03ActionsAndFilters.Controllers
{
    class MyKlineNeedBugFixAttribute : Attribute { }

    [MyKlineNeedBugFix]

    [MyLoggerActionFilter]
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("inside index");
            return View();
        }

        public IActionResult Image() { 
        
         return File("/veggie.jpg", "image/jpeg");
        }

        [Route("/v1/kline/myimage",Name ="myImageRoute")]
        public IActionResult GetImage() {
            return Image();
        }
        
        public IActionResult RedirectV1() {
            return RedirectToRoute("myImageRoute");
        }

    }
}
