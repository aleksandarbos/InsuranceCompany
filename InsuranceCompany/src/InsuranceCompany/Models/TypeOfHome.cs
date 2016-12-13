using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class TypeOfHome
    {
        public TypeOfHome()
        {
            Home = new HashSet<Home>();
        }

        public int HtId { get; set; }
        public string HtName { get; set; }

        public virtual ICollection<Home> Home { get; set; }
    }
}
