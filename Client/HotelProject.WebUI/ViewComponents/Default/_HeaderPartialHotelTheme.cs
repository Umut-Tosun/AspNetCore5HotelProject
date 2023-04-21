using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _HeaderPartialHotelTheme : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
