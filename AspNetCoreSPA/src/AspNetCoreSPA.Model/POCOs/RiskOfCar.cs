using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class RiskOfCar
    {
        public int Carid { get; set; }
        public int RId { get; set; }
        public int RocId { get; set; }

        public virtual Car Car { get; set; }
        public virtual Risk R { get; set; }
    }
}
