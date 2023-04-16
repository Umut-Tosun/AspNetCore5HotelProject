using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateUserDto
    {
        [Required(ErrorMessage ="Bu alan zorunludur.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
    }
}
