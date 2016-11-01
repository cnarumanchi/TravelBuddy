using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPartner.Data.Entities;

namespace TravelPartner.Data.Mapping
{
    public class CommentMap: EntityTypeConfiguration<Comment>
    {
        private string SchemaName = "TravelPartner";
        public CommentMap()
        {
            HasKey(x => x.CommentId);
            ToTable("Comments", SchemaName);
        }
    }
}
