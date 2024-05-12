using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Middleware.Middlewares
{
    public class HelloMiddleware
    {
         RequestDelegate _next;

        public HelloMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpcontext)
        {
            Console.WriteLine("Start Hello middleware!");
            await _next.Invoke(httpcontext);
            Console.WriteLine("End Hello middleware!");
        }
    }
}
