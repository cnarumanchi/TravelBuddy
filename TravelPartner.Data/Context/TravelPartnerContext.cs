using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPartner.Data.Entities;
using TravelPartner.Data.Mapping;

namespace TravelPartner.Data.Context
{
   public class TravelPartnerContext : DbContext
    {
       public TravelPartnerContext()
           : base("TravelPartnerDBConnection")
        {
            //Database.SetInitializer<TravelPartnerContext>(new DropCreateDatabaseIfModelChanges<TravelPartnerContext>());
        }
     
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Add all the fluent Mappings
            modelBuilder.Configurations.Add(new HotelMap());
            modelBuilder.Configurations.Add(new PackageMap());
            modelBuilder.Configurations.Add(new PostMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
        //Add all the dbsets of entities
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Login> LoginDetails { get; set; }

    }
}
