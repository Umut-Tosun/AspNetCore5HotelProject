using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var Services = _serviceService.GetList();
            return Ok(Services);
        }
        [HttpPost]
        public IActionResult AddService(Service Service)
        {
            _serviceService.Insert(Service);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var Service = _serviceService.GetById(id);
            _serviceService.Delete(Service);

            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service Service)
        {
            _serviceService.Update(Service);
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult GetServiceById(int id)
        {
            var Service = _serviceService.GetById(id);
            return Ok(Service);
        }
    }
}
