using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _RoomService;

        public RoomController(IRoomService RoomService)
        {
            _RoomService = RoomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var Rooms = _RoomService.GetList();
            return Ok(Rooms);
        }
        [HttpPost]
        public IActionResult AddRoom(Room Room)
        {
            _RoomService.Insert(Room);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var Room = _RoomService.GetById(id);
            _RoomService.Delete(Room);

            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room Room)
        {
            _RoomService.Update(Room);
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult GetRoomById(int id)
        {
            var Room = _RoomService.GetById(id);
            return Ok(Room);
        }
    }
}
