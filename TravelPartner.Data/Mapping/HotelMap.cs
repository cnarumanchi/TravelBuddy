using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPartner.Data.Entities;

namespace TravelPartner.Data.Mapping
{
    public class HotelMap : EntityTypeConfiguration<Hotel>
    {
        private string SchemaName = "TravelPartner";
        public HotelMap()
        {
            HasKey(x => x.HotelId);
            ToTable("Hotels", SchemaName);
        }
    }
}
