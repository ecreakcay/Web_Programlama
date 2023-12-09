using Microsoft.AspNetCore.Mvc;

namespace UcakRez.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
