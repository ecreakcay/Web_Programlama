using Microsoft.AspNetCore.Mvc;

namespace UcakRez.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
