using Microsoft.AspNetCore.Builder;

namespace Middleware.Extensions
{
    static public class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationbuilder)
        {
            return applicationbuilder.UseMiddleware<Middlewares.HelloMiddleware>();
        }

    }
}
