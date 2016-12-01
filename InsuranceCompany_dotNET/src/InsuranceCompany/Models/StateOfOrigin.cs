using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class StateOfOrigin
    {
        public StateOfOrigin()
        {
            City = new HashSet<City>();
        }

        public int StId { get; set; }
        public string StName { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}
