using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class Home
    {
        public Home()
        {
            SubjectOfInsurance = new HashSet<SubjectOfInsurance>();
        }

        public int HomeId { get; set; }
        public int HtId { get; set; }
        public int HomeSquares { get; set; }
        public string HomeBuildingYear { get; set; }
        public string HomeAddress { get; set; }

        public virtual ICollection<SubjectOfInsurance> SubjectOfInsurance { get; set; }
        public virtual TypeOfHome Ht { get; set; }
    }
}
