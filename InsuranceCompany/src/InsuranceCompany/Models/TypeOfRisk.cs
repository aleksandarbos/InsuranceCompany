using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class TypeOfRisk
    {
        public string Name { get; set; }
        public int IdType { get; set; }
        public int? RtId { get; set; }

        public virtual Risk Rt { get; set; }
    }
}
