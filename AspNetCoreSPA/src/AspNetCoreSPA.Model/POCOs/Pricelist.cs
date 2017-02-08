using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class Pricelist
    {
        public Pricelist()
        {
            PricelistItem = new HashSet<PricelistItem>();
        }

        public int PricelistId { get; set; }
        public DateTime PricelistStartDate { get; set; }
        public DateTime? PricelistEndDate { get; set; }

        public virtual ICollection<PricelistItem> PricelistItem { get; set; }
    }
}
