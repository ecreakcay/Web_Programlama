using Microsoft.AspNetCore.Mvc;

namespace UcakRez.ViewComponents.MemberLayout
{
    public class _MemberLayoutHeaderContent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
