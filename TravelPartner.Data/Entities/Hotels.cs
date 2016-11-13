using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPartner.Data.Entities
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string DisplayText { get; set; }
        public string Content { get; set; }
        public string Images { get; set; }
    }
}
