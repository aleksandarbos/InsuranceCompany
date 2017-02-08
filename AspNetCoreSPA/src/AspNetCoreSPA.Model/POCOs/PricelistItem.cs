using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class PricelistItem
    {
        public PricelistItem()
        {
            InsurancePackage = new HashSet<InsurancePackage>();
            Policy = new HashSet<Policy>();
        }

        public int PlItemId { get; set; }
        public int PricelistId { get; set; }
        public decimal? PlPrice { get; set; }

        public virtual ICollection<InsurancePackage> InsurancePackage { get; set; }
        public virtual ICollection<Policy> Policy { get; set; }
        public virtual Pricelist Pricelist { get; set; }
    }
}
