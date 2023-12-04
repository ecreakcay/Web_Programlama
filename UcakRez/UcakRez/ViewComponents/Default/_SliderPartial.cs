using Microsoft.AspNetCore.Mvc;

namespace UcakRez.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View();
        
        }
    }
}
