using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MVCWebApplication5.Filters
{
    public class CustomAuthorizationFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (string.IsNullOrWhiteSpace(context.HttpContext.Session.GetString("UserName")))
            {
                context.Result=new RedirectToRouteResult(new RouteValueDictionary {
                { "controller","Users"},{"action","Create" }});
            }
        }
    }
}
