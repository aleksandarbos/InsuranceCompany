using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class AgeGroup
    {
        public AgeGroup()
        {
            Client = new HashSet<Client>();
        }

        public int AgId { get; set; }
        public int? CoeffId { get; set; }
        public string AgNameEn { get; set; }
        public string AgNameSrb { get; set; }

        public virtual ICollection<Client> Client { get; set; }
        public virtual Coefficient Coeff { get; set; }
    }
}
