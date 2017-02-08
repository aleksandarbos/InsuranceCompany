using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class RateOfPdv
    {
        public int PdvRateId { get; set; }
        public int PdvId { get; set; }
        public DateTime? ValidUntil { get; set; }
        public decimal? Rate { get; set; }

        public virtual Pdv Pdv { get; set; }
    }
}
