﻿using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UcakRez.ViewComponents.MemberDashboard
{
    public class _PlatformSetting : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}
