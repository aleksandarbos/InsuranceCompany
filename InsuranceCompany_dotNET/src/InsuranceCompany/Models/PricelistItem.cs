using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class PricelistItem
    {
        public int PlItemId { get; set; }
        public int PricelistId { get; set; }
        public int? PackageId { get; set; }

        public virtual Package Package { get; set; }
        public virtual Pricelist Pricelist { get; set; }
    }
}
