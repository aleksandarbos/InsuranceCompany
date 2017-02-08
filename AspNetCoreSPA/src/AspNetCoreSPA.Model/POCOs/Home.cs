using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class Home
    {
        public Home()
        {
            RiskOfHouse = new HashSet<RiskOfHouse>();
            SubjectOfInsurance = new HashSet<SubjectOfInsurance>();
        }

        public int HomeId { get; set; }
        public int HomeSquares { get; set; }
        public DateTime? HomeBuildingYear { get; set; }
        public string HomeAddress { get; set; }
        public int? HomeValue { get; set; }
        public DateTime? HomeStartDate { get; set; }
        public DateTime? HomeEndDate { get; set; }

        public virtual ICollection<RiskOfHouse> RiskOfHouse { get; set; }
        public virtual ICollection<SubjectOfInsurance> SubjectOfInsurance { get; set; }
    }
}
