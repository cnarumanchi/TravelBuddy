using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPartner.Data.Entities
{
    public class postVM
    {
        public string Title { get; set; }
        public string FromDate { get; set; } //Jan 10 2016
        public string FromLocation { get; set; }
        public string ToDate { get; set; } //Jan 20 2016
        public string ToLocation { get; set; } //Hyderabad
        public string Body { get; set; }
    }
}
