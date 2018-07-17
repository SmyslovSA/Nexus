using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nexus.Website.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [Authorize(Roles ="saler")]
        public ActionResult Index()
        {
            return View();
        }
    }
}