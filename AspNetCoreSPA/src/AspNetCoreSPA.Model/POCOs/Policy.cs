using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class Policy
    {
        public Policy()
        {
            Client = new HashSet<Client>();
        }

        public int PolicyId { get; set; }
        public int RId { get; set; }
        public int? PackageId { get; set; }
        public int ClientId { get; set; }
        public int PdvId { get; set; }
        public int? PlItemId { get; set; }
        public int IiId { get; set; }
        public DateTime PolicyStartOfInsurance { get; set; }
        public DateTime? PolicyDstEndOfInsurance { get; set; }

        public virtual ICollection<Client> Client { get; set; }
        public virtual Client ClientNavigation { get; set; }
        public virtual SubjectOfInsurance Ii { get; set; }
        public virtual InsurancePackage Package { get; set; }
        public virtual Pdv Pdv { get; set; }
        public virtual PricelistItem PlItem { get; set; }
        public virtual Risk R { get; set; }
    }
}
