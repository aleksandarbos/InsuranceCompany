using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class RiskOfHouse
    {
        public int RId { get; set; }
        public int HomeId { get; set; }
        public int RohId { get; set; }

        public virtual Home Home { get; set; }
        public virtual Risk R { get; set; }
    }
}
