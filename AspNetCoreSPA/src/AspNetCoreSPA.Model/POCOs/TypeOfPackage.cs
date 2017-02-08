using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class TypeOfPackage
    {
        public TypeOfPackage()
        {
            InsurancePackage = new HashSet<InsurancePackage>();
        }

        public int TopId { get; set; }
        public string TopName { get; set; }

        public virtual ICollection<InsurancePackage> InsurancePackage { get; set; }
    }
}
