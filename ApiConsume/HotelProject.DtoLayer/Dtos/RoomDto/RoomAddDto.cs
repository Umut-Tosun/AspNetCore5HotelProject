using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Bu alan zorunludur.")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int BedCount { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int BathCount { get; set; }
        public string CoverImageUrl { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Description { get; set; }
    }
}
