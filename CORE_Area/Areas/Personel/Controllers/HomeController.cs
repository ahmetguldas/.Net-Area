using Microsoft.AspNetCore.Mvc;

namespace CORE_Area.Areas.Personel.Controllers
{
    [Area("Personel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
