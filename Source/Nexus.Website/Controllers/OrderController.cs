using System.Web.Mvc;

namespace Nexus.Website.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        [Authorize(Roles ="customer")]
        public ActionResult Index()
        {
            return View();
        }
    }
}