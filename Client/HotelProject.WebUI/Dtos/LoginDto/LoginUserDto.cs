using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Bu Alan Zorunludur")]
       public string userName { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
       public string password { get; set; }
    }
}
