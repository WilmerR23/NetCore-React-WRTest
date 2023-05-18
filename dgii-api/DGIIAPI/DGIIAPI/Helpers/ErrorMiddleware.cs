using DGII.BLL.Contracts;
using System.Net;
using DGII.BOL.Models;

namespace DGII.API.Helpers
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerService _logger;
        public ErrorMiddleware(RequestDelegate next, ILoggerService logger)
        {
            _logger = logger;
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex}");
                await HandleException(httpContext, ex);
            }
        }
        private async Task HandleException(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            await context.Response.WriteAsync(new Error()
            {
                StatusCode = context.Response.StatusCode,
                Message = "Ha ocurrido un error inesperado, favor contactar al departamento de tecnologia de la DGII"
            }.ToString());
        }
    }
}
