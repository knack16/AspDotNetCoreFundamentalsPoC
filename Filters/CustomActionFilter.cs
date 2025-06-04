using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ProductCatalogAPI.Filters
{
    public class CustomActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine("Before action executes.");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("After action executes.");
    }
    }
}