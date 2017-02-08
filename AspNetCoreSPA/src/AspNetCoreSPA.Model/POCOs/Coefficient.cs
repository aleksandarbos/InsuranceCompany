using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class Coefficient
    {
        public Coefficient()
        {
            AgeGroup = new HashSet<AgeGroup>();
            Continent = new HashSet<Continent>();
            Risk = new HashSet<Risk>();
        }

        public int CoeffId { get; set; }
        public decimal? CoeffValue { get; set; }
        public DateTime? CoeffDate { get; set; }

        public virtual ICollection<AgeGroup> AgeGroup { get; set; }
        public virtual ICollection<Continent> Continent { get; set; }
        public virtual ICollection<Risk> Risk { get; set; }
    }
}
