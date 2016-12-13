using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class SubjectOfInsurance
    {
        public SubjectOfInsurance()
        {
            Policy = new HashSet<Policy>();
        }

        public int IiId { get; set; }
        public int? ItId { get; set; }
        public int? Carid { get; set; }
        public int? DstId { get; set; }
        public int? HomeId { get; set; }

        public virtual ICollection<Policy> Policy { get; set; }
        public virtual Car Car { get; set; }
        public virtual Destination Dst { get; set; }
        public virtual Home Home { get; set; }
        public virtual TypeOfInsurance It { get; set; }
    }
}
