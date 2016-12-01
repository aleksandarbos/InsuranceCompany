using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class Destination
    {
        public Destination()
        {
            SubjectOfInsurance = new HashSet<SubjectOfInsurance>();
        }

        public int DstId { get; set; }
        public string DstName { get; set; }
        public int DstDays { get; set; }

        public virtual ICollection<SubjectOfInsurance> SubjectOfInsurance { get; set; }
    }
}
