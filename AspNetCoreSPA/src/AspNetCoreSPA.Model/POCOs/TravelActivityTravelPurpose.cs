using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class TravelActivityTravelPurpose
    {
        public int RId { get; set; }
        public int TpId { get; set; }
        public int TpRId { get; set; }

        public virtual Risk R { get; set; }
        public virtual TravelPurpose Tp { get; set; }
    }
}
