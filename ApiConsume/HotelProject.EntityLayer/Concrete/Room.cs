using HotelProject.EntityLayer.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Room : BaseEntity
    {
        public string Title { get; set; }
        public string RoomNumber { get; set; }
        public int BedCount { get; set; }
        public int BathCount { get; set; }
        public string CoverImageUrl { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

    }
}
