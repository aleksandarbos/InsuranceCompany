using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class RiskTypeOfInsurance
    {
        public int RtId { get; set; }
        public int ItId { get; set; }

        public virtual TypeOfInsurance It { get; set; }
        public virtual Risk Rt { get; set; }
    }
}
