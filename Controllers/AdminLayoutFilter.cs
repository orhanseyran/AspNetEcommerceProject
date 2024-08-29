using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class AdminLayoutFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        var controller = context.Controller as Controller;
        if (controller != null)
        {
            controller.ViewBag.Layout = "~/Views/Shared/_AdminLayout.cshtml";
        }
    }

    public void OnActionExecuted(ActionExecutedContext context) { }
}
