using Microsoft.AspNetCore.Mvc;

namespace UcakRez.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
