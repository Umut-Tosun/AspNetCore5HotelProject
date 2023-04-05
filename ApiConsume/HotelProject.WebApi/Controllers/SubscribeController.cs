using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _SubscribeService;

        public SubscribeController(ISubscribeService SubscribeService)
        {
            _SubscribeService = SubscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var Subscribes = _SubscribeService.GetList();
            return Ok(Subscribes);
        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe Subscribe)
        {
            _SubscribeService.Insert(Subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var Subscribe = _SubscribeService.GetById(id);
            _SubscribeService.Delete(Subscribe);

            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe Subscribe)
        {
            _SubscribeService.Update(Subscribe);
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult GetSubscribeById(int id)
        {
            var Subscribe = _SubscribeService.GetById(id);
            return Ok(Subscribe);
        }
    }
}
