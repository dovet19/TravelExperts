using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class PackagesProductsSupplierDB
    {
        /// <summary>
        /// Add new PackagesProductsSupplier
        /// </summary>
        /// <param name="newPkgProdSup"></param>
        public static void AddPkgProdSup(PackagesProductsSupplier newPkgProdSup)
        {
            if (newPkgProdSup != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    db.PackagesProductsSuppliers.Add(newPkgProdSup);
                    db.SaveChanges();
                }
            }
        }

    }
}
