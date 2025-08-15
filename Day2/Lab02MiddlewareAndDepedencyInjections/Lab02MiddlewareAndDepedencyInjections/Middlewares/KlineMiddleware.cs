using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Lab02MiddlewareAndDepedencyInjections.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class KlineMiddleware
    {
        private readonly RequestDelegate _nextMiddleWare;

        public KlineMiddleware(RequestDelegate next)
        {
            _nextMiddleWare = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            //pre
            Console.WriteLine("preprocessing of Kline");
           await  _nextMiddleWare(httpContext);
            //post
            Console.WriteLine("postprocessing of Kline");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class KlineMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyKlineMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<KlineMiddleware>();
        }
    }
}
