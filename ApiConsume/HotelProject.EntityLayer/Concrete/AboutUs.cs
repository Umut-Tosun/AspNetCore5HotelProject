using HotelProject.EntityLayer.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class AboutUs : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
