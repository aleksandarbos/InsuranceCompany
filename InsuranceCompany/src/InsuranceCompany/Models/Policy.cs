using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class Policy
    {
        public Policy()
        {
            Client = new HashSet<Client>();
        }

        public int PolicyId { get; set; }
        public int RtId { get; set; }
        public int PdvId { get; set; }
        public int ClientId { get; set; }
        public int? PackageId { get; set; }
        public int? YearId { get; set; }
        public int EnId { get; set; }
        public int CurrencyId { get; set; }
        public int CpId { get; set; }
        public int IiId { get; set; }
        public DateTime PolicyStartOfInsurance { get; set; }
        public DateTime? PolicyDstEndOfInsurance { get; set; }

        public virtual ICollection<Client> Client { get; set; }
        public virtual Client ClientNavigation { get; set; }
        public virtual InsuranceCompany Cp { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Employee En { get; set; }
        public virtual SubjectOfInsurance Ii { get; set; }
        public virtual Package Package { get; set; }
        public virtual Pdv Pdv { get; set; }
        public virtual Risk Rt { get; set; }
        public virtual BusinessYear Year { get; set; }
    }
}
