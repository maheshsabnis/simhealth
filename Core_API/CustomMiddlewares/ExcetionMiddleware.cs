using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Core_API.CustomMiddlewares
{
    /// <summary>
    /// Error Detail class
    /// </summary>
    public class ErrorInformation
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }

    /// <summary>
    /// Custom Middleware Class
    /// 1. Ijected with RequestDelegate
    /// 2. Must have InvokeAsync(HttpContext) method
    /// </summary>
    public class ExcetionMiddleware
    {
        private readonly RequestDelegate next;
        public ExcetionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        /// <summary>
        /// Method will be executed Asynchronusly this method contains LOgic 
        /// </summary>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // if no error while processing request
                // // then just move to next mileware in the pipelined
                // 
                await next(context);
            }
            catch (Exception ex)
            {
                // else Handle the exception and generate response
                // 1. Set the Error Code
                context.Response.StatusCode = 500;
                // 2. Set teh Error Message
                string message = ex.Message;
                // 3. Well DEfine the Error Message
                var errorInfo = new ErrorInformation()
                {
                     ErrorCode = context.Response.StatusCode,
                     ErrorMessage = message
                };
                // 4. Write the response
                await context.Response.WriteAsJsonAsync(errorInfo);
            }
        }
    }

    /// <summary>
    /// Middleware extension class
    /// </summary>
    public static class MiddlewareExtension
    {
        public static void UseCustomExceptionHandler(this IApplicationBuilder builder)
        {
            // Register the ExcetionMiddleware class as ASP.NET Core Middleware
            builder.UseMiddleware<ExcetionMiddleware>();
        }
    }
}
