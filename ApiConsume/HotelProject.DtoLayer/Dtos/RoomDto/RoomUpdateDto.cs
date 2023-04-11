using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int BedCount { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int BathCount { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string CoverImageUrl { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(500,ErrorMessage ="En Fazla 500 karakterlik bir açıklama girebilirsiniz.")]
        public string Description { get; set; }
    }
}
