using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class BankAccount
    {
        public int Ac1Id { get; set; }
        public int ClientId { get; set; }
        public int CpId { get; set; }
        public int BankId { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual Client Client { get; set; }
        public virtual InsuranceCompany Cp { get; set; }
    }
}
