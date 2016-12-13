using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class Risk
    {
        public Risk()
        {
            Policy = new HashSet<Policy>();
            RiskTypeOfInsurance = new HashSet<RiskTypeOfInsurance>();
            TypeOfRisk = new HashSet<TypeOfRisk>();
        }

        public int RtId { get; set; }
        public string RtName { get; set; }
        public decimal? RtCoefficient { get; set; }

        public virtual ICollection<Policy> Policy { get; set; }
        public virtual ICollection<RiskTypeOfInsurance> RiskTypeOfInsurance { get; set; }
        public virtual ICollection<TypeOfRisk> TypeOfRisk { get; set; }
    }
}
