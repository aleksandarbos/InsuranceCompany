using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class TypeOfInsurance
    {
        public TypeOfInsurance()
        {
            RiskTypeOfInsurance = new HashSet<RiskTypeOfInsurance>();
            SubjectOfInsurance = new HashSet<SubjectOfInsurance>();
        }

        public int ItId { get; set; }
        public int PackageId { get; set; }
        public string ItName { get; set; }

        public virtual ICollection<RiskTypeOfInsurance> RiskTypeOfInsurance { get; set; }
        public virtual ICollection<SubjectOfInsurance> SubjectOfInsurance { get; set; }
        public virtual Package Package { get; set; }
    }
}
