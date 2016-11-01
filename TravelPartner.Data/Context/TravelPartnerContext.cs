using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPartner.Data.Entities;

namespace TravelPartner.Data.Context
{
    class TravelPartnerContext : DbContext
    {
        public TravelPartnerContext() : base("TravelPartnerDBConnection")
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Package> Packages { get; set; }

    }
}
