using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPartner.Data.Context;
using TravelPartner.Data.Entities;

namespace TravelPartner.Data.Repository
{
    public class HotelRepository
    {
        TravelPartnerContext context;

		public HotelRepository()
        {
            context = new TravelPartnerContext();
        }

		public List<Hotel> showHotels()
        {
            return context.Hotels.Select(x=>x).ToList();
        }
        public List<Package> showPackages()
        {
            return context.Packages.Select(x => x).ToList();
        }
        public bool InsertHotel(Hotel hotel)
        {
            context.Hotels.Add(hotel);
            return true;
        }
    }
}
