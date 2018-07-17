using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nexus.Website.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        [Authorize(Roles ="admin,saler,customer")]
        public ActionResult Index()
        {
            return View();
        }
    }
}