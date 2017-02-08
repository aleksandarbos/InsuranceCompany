using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class TravelPurpose
    {
        public TravelPurpose()
        {
            SubjectOfInsurance = new HashSet<SubjectOfInsurance>();
            TravelActivityTravelPurpose = new HashSet<TravelActivityTravelPurpose>();
        }

        public int TpId { get; set; }
        public int PackageId { get; set; }
        public string TpNameEn { get; set; }
        public string TpNameSrb { get; set; }

        public virtual ICollection<SubjectOfInsurance> SubjectOfInsurance { get; set; }
        public virtual ICollection<TravelActivityTravelPurpose> TravelActivityTravelPurpose { get; set; }
        public virtual InsurancePackage Package { get; set; }
    }
}
