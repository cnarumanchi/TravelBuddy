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
    public class TravelPartnerInitializer : DropCreateDatabaseIfModelChanges<TravelPartnerContext>
    {
        protected override void Seed(TravelPartnerContext context)
        {
            //Add any default data or master data that is to be added to Database Tables repectively
            CreateHotelSeed(context);
            CreatePackageSeed(context);
            CreateLoginDetails(context);
        }

        private void CreateLoginDetails(TravelPartnerContext context)
        {
            var loginDetails = new Login
            {
                kusername = "Admin",
                kpassword = "Admin123",
            };
            context.LoginDetails.Add(loginDetails);
            context.SaveChanges();
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
            var hotels = new List<Hotel>()
            {
                new Hotel{Title="abc",DisplayText="This is the display text",Content="abcdefgh",Images="image1.jpe"}, 
                new Hotel{ Title="abc",DisplayText="This is the display text",Content="abcdefgh",Images="image1.jpe"}, 
                new Hotel{ Title="abc",DisplayText="This is the display text",Content="abcdefgh",Images="image1.jpe"}
                //Insert the Prepopulated list from http://www.travel-buddies.com/Default.aspx
            };
            context.Hotels.AddRange(hotels);
            context.SaveChanges();
        }
    }
}
