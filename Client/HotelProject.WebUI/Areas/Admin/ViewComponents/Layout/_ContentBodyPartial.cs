using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Areas.Admin.ViewComponents.Layout
{
    public class _ContentBodyPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
