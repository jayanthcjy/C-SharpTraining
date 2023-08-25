using DemoApplication.Controllers;
using DemoApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DemoApplication.Filters
{
    public class SampleActionFilter : ActionFilterAttribute
    {
        public override void  OnActionExecuting(ActionExecutingContext context)
        {
            // Do something before the action executes.
            Console.WriteLine("Before");
            if (true)
            {
                // Redirect to another view
                context.Result = new RedirectToActionResult("Privacy", "Home", null);

            }

        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            // Do something after the action executes.
            Console.WriteLine("After");
        }
    }
}
