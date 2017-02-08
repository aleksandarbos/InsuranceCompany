using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class Pdv
    {
        public Pdv()
        {
            Policy = new HashSet<Policy>();
            RateOfPdv = new HashSet<RateOfPdv>();
        }

        public int PdvId { get; set; }
        public string NamePdv { get; set; }

        public virtual ICollection<Policy> Policy { get; set; }
        public virtual ICollection<RateOfPdv> RateOfPdv { get; set; }
    }
}
