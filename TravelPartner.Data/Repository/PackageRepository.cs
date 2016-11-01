using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPartner.Data.Context;
using TravelPartner.Data.Entities;
using TravelPartner.Data.Interfaces;

namespace TravelPartner.Data.Repository
{
    public class PackageRepository: IPackageRepository
    {
        TravelPartnerContext context;

        public PackageRepository()
        {
            context = new TravelPartnerContext();
        }

        public List<Package> GetAll()
        {
            return context.Packages.Select(x => x).ToList();
        }

        public bool InsertPackage(Package package)
        {
            context.Packages.Add(package);
            return true;
        }
    }
}
