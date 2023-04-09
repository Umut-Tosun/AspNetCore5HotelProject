using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.WebUI.Areas.Admin.Models.Staff;
using HotelProject.WebUI.Methods;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StaffController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StaffController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44322/api/Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddStaff() => View();
        [HttpPost]
        public async Task<IActionResult> AddStaff(StaffViewModel staffViewModel,IFormFile FileUrl)
        {
            if (FileUrl != null) staffViewModel.imageUrl = FileService.CreateToIFormFile(FileUrl);
            else staffViewModel.imageUrl = "/content/default.png";

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(staffViewModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44322/api/Staff",stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Staff");
            }
            return View();
        }
        public async Task<IActionResult> DeleteStaff(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:44322/api/Staff?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction( "Index","Staff");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateStaff(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44322/api/Staff/id?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<StaffViewModel>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateStaff(StaffViewModel model,IFormFile FileUrl)
        {
            StafManager stafManager = new StafManager(new EfStaffDal(new Context()));
            var staff = stafManager.GetById(model.id);

            if (FileUrl != null) model.imageUrl = FileService.CreateToIFormFile(FileUrl);
            else model.imageUrl = staff.ImageUrl;

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync("https://localhost:44322/api/Staff/",content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Staff");
            }
            return View();
        }
    }
}

