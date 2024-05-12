using Microsoft.AspNetCore.Http;
using System.Security.Cryptography.X509Certificates;

namespace CustomRouteHandler.Handlers
{
    public class ExampleHandler
    {
        public RequestDelegate Handler()
        {
            return async c =>
            {
                await c.Response.WriteAsync("Hello from the example handler");
            };
        }
    }
}
