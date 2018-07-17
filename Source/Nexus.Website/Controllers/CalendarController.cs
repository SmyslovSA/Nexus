using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nexus.Website.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        [Authorize(Roles = "saler, customer")]
        public ActionResult Index()
        {
            return View();
        }
    }
}