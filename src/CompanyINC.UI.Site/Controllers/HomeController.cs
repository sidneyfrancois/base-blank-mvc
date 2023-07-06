using Microsoft.AspNetCore.Mvc;

namespace CompanyINC.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
