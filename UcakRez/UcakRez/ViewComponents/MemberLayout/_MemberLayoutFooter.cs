using Microsoft.AspNetCore.Mvc;

namespace UcakRez.ViewComponents.MemberLayout
{
    public class _MemberLayoutFooter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
