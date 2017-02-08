using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class Risk
    {
        public Risk()
        {
            Policy = new HashSet<Policy>();
            RiskOfCar = new HashSet<RiskOfCar>();
            RiskOfHouse = new HashSet<RiskOfHouse>();
            TravelActivityTravelPurpose = new HashSet<TravelActivityTravelPurpose>();
        }

        public int RId { get; set; }
        public int CoeffId { get; set; }
        public string RNameEn { get; set; }
        public string RDescriptionEn { get; set; }
        public string RNameSrb { get; set; }
        public string RDescriptionSrb { get; set; }

        public virtual ICollection<Policy> Policy { get; set; }
        public virtual ICollection<RiskOfCar> RiskOfCar { get; set; }
        public virtual ICollection<RiskOfHouse> RiskOfHouse { get; set; }
        public virtual ICollection<TravelActivityTravelPurpose> TravelActivityTravelPurpose { get; set; }
        public virtual Coefficient Coeff { get; set; }
    }
}
