using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace RouteStructure.Constraints
{
    public class CustomConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext,
            IRouter route,
            string routeKey,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            var idValue = values[routeKey];
            return true; 
            //throw new System.NotImplementedException();
        }
    }
}
