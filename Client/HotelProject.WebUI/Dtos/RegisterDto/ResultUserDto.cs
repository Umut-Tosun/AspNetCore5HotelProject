using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class ResultUserDto
    {
       
        public string FirstName { get; set; }     
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
    }
}
