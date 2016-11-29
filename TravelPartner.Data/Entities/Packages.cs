using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPartner.Data.Entities
{
    public class Package
    {
        public int PackageId{ get; set; }
        public string PackageTitle{ get; set; }
        public string Url{ get; set; }
        public string  DisplayText{ get; set; }
        public string Image { get; set; }
        public string Content{ get; set; }
        public string image2 { get; set; }
    }
}
