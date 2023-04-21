using HotelProject.WebUI.Areas.Admin.Models.Staff;
using HotelProject.WebUI.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult _NewsLetterPartialHotelTheme()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> _NewsLetterPartialHotelTheme(CreateSubscribeDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44322/api/Subscribe", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                var script = "<script>alert('Başarıyla abone oldunuz.');</script>";
                TempData["SuccessMessage"] = script;
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
