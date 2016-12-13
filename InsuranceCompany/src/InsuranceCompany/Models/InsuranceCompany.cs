using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class InsuranceCompanyModel
    {
        public InsuranceCompanyModel()
        {
            BankAccount = new HashSet<BankAccount>();
            BusinessYear = new HashSet<BusinessYear>();
            Employee = new HashSet<Employee>();
            Policy = new HashSet<Policy>();
            Pricelist = new HashSet<Pricelist>();
        }

        public int CpId { get; set; }
        public int CityId { get; set; }
        public string CpName { get; set; }
        public int Pib { get; set; }

        public virtual ICollection<BankAccount> BankAccount { get; set; }
        public virtual ICollection<BusinessYear> BusinessYear { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Policy> Policy { get; set; }
        public virtual ICollection<Pricelist> Pricelist { get; set; }
        public virtual City City { get; set; }
    }
}
