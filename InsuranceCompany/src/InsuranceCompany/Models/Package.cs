using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class Package
    {
        public Package()
        {
            ItemsOfPackage = new HashSet<ItemsOfPackage>();
            Policy = new HashSet<Policy>();
            PricelistItem = new HashSet<PricelistItem>();
            TypeOfInsurance = new HashSet<TypeOfInsurance>();
        }

        public int PackageId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ItemsOfPackage> ItemsOfPackage { get; set; }
        public virtual ICollection<Policy> Policy { get; set; }
        public virtual ICollection<PricelistItem> PricelistItem { get; set; }
        public virtual ICollection<TypeOfInsurance> TypeOfInsurance { get; set; }
    }
}
