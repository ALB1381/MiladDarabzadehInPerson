using Microsoft.AspNetCore.Mvc;

namespace MiladDarabzadeh.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
