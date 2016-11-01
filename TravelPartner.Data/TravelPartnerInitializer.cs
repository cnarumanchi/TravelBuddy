using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TravelPartner.Data.Context;
using TravelPartner.Data.Entities;

namespace TravelPartner.Data
{
    class TravelPartnerInitializer : DropCreateDatabaseIfModelChanges<TravelPartnerContext>
    {
        protected override void Seed(TravelPartnerContext context)
        {
            //Add any default data or master data that is to be added to Database Tables repectively
            CreateHotelSeed(context);
            CreatePackageSeed(context);
        }

        private void CreatePackageSeed(TravelPartnerContext context)
        {
            var package = new Package
            {
                //Insert the Prepopulated list from http://www.travel-buddies.com/Default.aspx
            };
            context.Packages.Add(package);
            context.SaveChanges();
        }

        private void CreateHotelSeed(TravelPartnerContext context)
        {
            var hotel = new Hotel
            {
                //Insert the Prepopulated list from http://www.travel-buddies.com/Default.aspx
            };
            context.Hotels.Add(hotel);
            context.SaveChanges();
        }
    }
}
