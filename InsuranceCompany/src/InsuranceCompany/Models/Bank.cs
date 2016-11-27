using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class Bank
    {
        public Bank()
        {
            BankAccount = new HashSet<BankAccount>();
        }

        public int BankId { get; set; }
        public string BankName { get; set; }

        public virtual ICollection<BankAccount> BankAccount { get; set; }
    }
}
