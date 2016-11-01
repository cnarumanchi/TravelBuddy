using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPartner.Data.Entities;

namespace TravelPartner.Data.Mapping
{
    public class PackageMap: EntityTypeConfiguration<Package>
    {
        private string SchemaName = "TravelPartner";
        public PackageMap()
        {
            HasKey(x => x.PackageId);
            ToTable("Packages", SchemaName);
        }
    }
}
