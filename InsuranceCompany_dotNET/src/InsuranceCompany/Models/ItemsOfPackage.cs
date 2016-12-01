using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class ItemsOfPackage
    {
        public int Id { get; set; }
        public int? PackageId { get; set; }

        public virtual Package Package { get; set; }
    }
}
