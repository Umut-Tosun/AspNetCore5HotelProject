using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        [HttpGet]
        public IActionResult AboutUsList()
        {
            var AboutUss = _aboutUsService.GetList();
            return Ok(AboutUss);
        }
        [HttpPost]
        public IActionResult AddAboutUs(AboutUs AboutUs)
        {
            _aboutUsService.Insert(AboutUs);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAboutUs(int id)
        {
            var AboutUs = _aboutUsService.GetById(id);
            _aboutUsService.Delete(AboutUs);

            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAboutUs(AboutUs AboutUs)
        {
            _aboutUsService.Update(AboutUs);
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult GetAboutUsById(int id)
        {
            var AboutUs = _aboutUsService.GetById(id);
            return Ok(AboutUs);
        }
    }
}
