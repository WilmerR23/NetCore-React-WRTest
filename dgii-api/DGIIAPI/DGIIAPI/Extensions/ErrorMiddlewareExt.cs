using Microsoft.AspNetCore.Diagnostics;
using DGII.API.Helpers;
using System.Net;

namespace DGII.API.Extensions
{
    public static class ErrorMiddlewareExt
    {
        public static void ConfigureCustomExceptionMiddleware(this WebApplication app)
        {
            app.UseMiddleware<ErrorMiddleware>(); //Metodo de extension para configurar el middleware
        }
    }
}
