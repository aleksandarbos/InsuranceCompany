using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class Pricelist
    {
        public Pricelist()
        {
            PricelistItem = new HashSet<PricelistItem>();
        }

        public int PricelistId { get; set; }
        public int CpId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<PricelistItem> PricelistItem { get; set; }
        public virtual InsuranceCompany Cp { get; set; }
    }
}
