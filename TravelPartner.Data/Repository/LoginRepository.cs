using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPartner.Data.Context;
using TravelPartner.Data.Entities;

namespace TravelPartner.Data.Repository
{
    public class LoginRepository
    {
        TravelPartnerContext context;

        public LoginRepository()
        {
            context = new TravelPartnerContext();
        }

        public List<Login> GetAllUsers()
        {
            return context.LoginDetails.Select(x => x).ToList();
        }

        public int InsertUser(string uname, string pass)
        {
            var login = new Login
            {
                kusername = uname,
                kpassword = pass
            };
            context.LoginDetails.Add(login);
            return context.SaveChanges();
        }

    }
}
