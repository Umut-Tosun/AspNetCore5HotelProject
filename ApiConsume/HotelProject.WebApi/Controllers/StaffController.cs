using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StafController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StafController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var staffs = _staffService.GetList();
            return Ok(staffs);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.Insert(staff);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
           var staff= _staffService.GetById(id);
            _staffService.Delete(staff);

            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.Update(staff);
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult GetStaffById(int id)
        {
            var staff = _staffService.GetById(id);
            return Ok(staff);
        }
    }
}
