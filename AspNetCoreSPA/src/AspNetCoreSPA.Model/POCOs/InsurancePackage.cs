using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class InsurancePackage
    {
        public InsurancePackage()
        {
            ItemsOfPackage = new HashSet<ItemsOfPackage>();
            Policy = new HashSet<Policy>();
            TravelPurpose = new HashSet<TravelPurpose>();
        }

        public int PackageId { get; set; }
        public int? PlItemId { get; set; }
        public int? TopId { get; set; }
        public string PackageNameEn { get; set; }
        public string PackageDescriptionEn { get; set; }
        public string PackageNameSrb { get; set; }
        public string PackageDescriptionSrb { get; set; }

        public virtual ICollection<ItemsOfPackage> ItemsOfPackage { get; set; }
        public virtual ICollection<Policy> Policy { get; set; }
        public virtual ICollection<TravelPurpose> TravelPurpose { get; set; }
        public virtual PricelistItem PlItem { get; set; }
        public virtual TypeOfPackage Top { get; set; }
    }
}
