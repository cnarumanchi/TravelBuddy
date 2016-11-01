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
        [Required]
        public string Title{ get; set; }
        [Required]
        public  string Url { get; set; }
        [Required]
        public  string DisplayText { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
