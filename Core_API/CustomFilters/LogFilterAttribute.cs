using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System.Diagnostics;
namespace Core_API.CustomFilters
{
    public class LogFilterAttribute : ActionFilterAttribute
    {
        private void LogRequest(string currentExecutionStatus, RouteData route)
        { 
            string action = route.Values["action"].ToString();
            string controller = route.Values["controller"].ToString();
            string logMessage = $"Current Executiion Status is = {currentExecutionStatus} in Action Method {action} in contoller {controller}"; 

            Debug.WriteLine(logMessage);

        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            LogRequest("OnActionExecuting", context.RouteData);
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            LogRequest("OnActionExecuted", context.RouteData);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            LogRequest("OnResultExecuting", context.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            LogRequest("OnResultExecuted", context.RouteData);
        }
    }
}
