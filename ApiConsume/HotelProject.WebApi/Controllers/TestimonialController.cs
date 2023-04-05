using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _TestimonialService;

        public TestimonialController(ITestimonialService TestimonialService)
        {
            _TestimonialService = TestimonialService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var Services = _TestimonialService.GetList();
            return Ok(Services);
        }
        [HttpPost]
        public IActionResult AddService(Testimonial testimonial)
        {
            _TestimonialService.Insert(testimonial);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var testimonial = _TestimonialService.GetById(id);
            _TestimonialService.Delete(testimonial);

            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Testimonial testimonial)
        {
            _TestimonialService.Update(testimonial);
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult GetServiceById(int id)
        {
            var testimonial = _TestimonialService.GetById(id);
            return Ok(testimonial);
        }
    }
}
