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
                new Hotel{Title="Inca Heartland",DisplayText="No Text",Content="Experience the archaeological highlights and the cultural treasures of the Andean highlands, then uncover the secrets of the mysterious Nazca Lines and Peru's desert coast on this incredible 3-week adventure. Embrace Incan culture past and present in Cusco and get a taste of Bolivian culture.",Images="image1.jpe",Url="https://www.gadventures.com/trips/inca-heartland/1068/?PID=5806206"}, 
                new Hotel{ Title="Backroads of Japan",DisplayText="Japan",Content="Tokyo and Kyotothe modern and imperial capitals of Japan, respectivelyrepresent the perfect merger of the ancient and the contemporary. On this trip, youll thoroughly explore both and everything in between, from traditional villages and miles of rice fields to ancient temples and the stunning visuals.",Images="image1.jpe", Url="https://www.gadventures.com/trips/backroads-of-japan/812/?PID=5806206"}, 
                new Hotel{ Title="Naadam Mangolia",DisplayText="Mangolia",Content="Wander the land that gave the world Genghis Khan and experience the rich pageantry and intense competitions of the legendary Naadam Festival. Witness giants wrestle, archers hit impossible targets and horses race across grasslands to glory. Travel the regions steppes and sand dunes.",Images="image1.jpe", Url="https://www.gadventures.com/trips/naadam-festival-mongolia/3439/?PID=5806206"}
                //Insert the Prepopulated list from http://www.travel-buddies.com/Default.aspx
            };
            context.Hotels.AddRange(hotels);
            context.SaveChanges();
        }
    }
}
