using Microsoft.AspNetCore.Mvc;

namespace CatalogAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
