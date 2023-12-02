using Microsoft.AspNetCore.Mvc;

namespace UcakRez.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
