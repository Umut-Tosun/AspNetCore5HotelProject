﻿using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _HeadPartialHotelTheme : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
