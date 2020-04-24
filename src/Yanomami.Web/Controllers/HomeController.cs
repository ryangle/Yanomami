using Microsoft.AspNetCore.Mvc;

namespace Yanomami.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
