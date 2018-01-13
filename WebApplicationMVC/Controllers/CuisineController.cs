using System.Web.Mvc;
using WebApplicationMVC.Filters;

namespace WebApplicationMVC.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        //[Authorize]
        [Log]
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name);
            return Content("TODO Search view for cuisine: "+ message);
        }
    }
}