using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Search()
        {
            return Content("TODO Search view for cuisine: "+ RouteData.Values["Name"]);
        }
    }
}