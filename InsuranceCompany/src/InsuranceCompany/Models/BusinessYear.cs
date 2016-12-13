using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class BusinessYear
    {
        public BusinessYear()
        {
            Policy = new HashSet<Policy>();
        }

        public int YearId { get; set; }
        public int CpId { get; set; }

        public virtual ICollection<Policy> Policy { get; set; }
        public virtual InsuranceCompanyModel Cp { get; set; }
    }
}
