using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Lab03ActionsAndFilters.Filters
{
    public class MyLoggerActionFilter : ActionFilterAttribute
    {
        private string _controllerName=string.Empty;
        private string _actionName=string.Empty;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
             _controllerName = context.RouteData.Values["controller"].ToString();
            _actionName = context.RouteData.Values["action"].ToString();
            Console.WriteLine($"Before execution action {_actionName} " +
                $"inside {_controllerName} time is : {DateTime.Now.ToLongDateString()}");

          //  context.Result = new RedirectResult("https://www.google.com");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
           
            Console.WriteLine($"After execution action {_actionName} " +
                $"inside {_controllerName} time is : {DateTime.Now.ToLongDateString()}");

        }
    }
}
