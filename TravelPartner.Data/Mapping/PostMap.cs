using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPartner.Data.Entities;

namespace TravelPartner.Data.Mapping
{
    public class PostMap : EntityTypeConfiguration<Post>
    {
        private string SchemaName = "TravelPartner";
        public PostMap()
        {
            HasKey(x => x.PostId);
            ToTable("Posts", SchemaName);
        }
    }
}
