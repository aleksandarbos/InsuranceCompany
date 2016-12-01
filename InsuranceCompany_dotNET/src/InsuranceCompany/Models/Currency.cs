using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class Currency
    {
        public Currency()
        {
            Policy = new HashSet<Policy>();
        }

        public int CurrencyId { get; set; }

        public virtual ICollection<Policy> Policy { get; set; }
    }
}
