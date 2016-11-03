using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPartner.Data.Entities;

namespace TravelPartner.Data.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        private string SchemaName = "TravelPartner";
        public UserMap()
        {
            HasKey(x => x.UserId);
            ToTable("Users", SchemaName);
        }
    }
}
