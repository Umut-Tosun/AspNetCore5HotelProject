using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _FooterPartialHotelTheme : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
