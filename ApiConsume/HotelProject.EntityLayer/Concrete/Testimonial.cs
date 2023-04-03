using HotelProject.EntityLayer.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Testimonial : BaseEntity
    {
        public string FullName { get; set; }
        public string Subject { get; set; }
        public string Comment { get; set; }
    }
}
