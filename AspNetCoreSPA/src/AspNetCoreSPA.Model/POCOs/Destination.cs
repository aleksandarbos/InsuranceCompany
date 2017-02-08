using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class Destination
    {
        public Destination()
        {
            SubjectOfInsurance = new HashSet<SubjectOfInsurance>();
        }

        public int DstId { get; set; }
        public int? StId { get; set; }
        public int DstDays { get; set; }

        public virtual ICollection<SubjectOfInsurance> SubjectOfInsurance { get; set; }
        public virtual Country St { get; set; }
    }
}
