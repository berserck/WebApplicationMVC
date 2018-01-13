using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplicationMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // /Cuisine/french
            routes.MapRoute(
                name: "",
                url: "cuisine/{name}",
                defaults: new { controller = "Cuisine", action="Search", name = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
