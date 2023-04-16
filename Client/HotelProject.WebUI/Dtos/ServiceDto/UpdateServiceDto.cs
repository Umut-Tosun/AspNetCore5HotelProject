using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        public string IconUrl { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        public string Description { get; set; }
    }
}
