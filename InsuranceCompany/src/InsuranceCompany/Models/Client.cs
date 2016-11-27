using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class Client
    {
        public Client()
        {
            BankAccount = new HashSet<BankAccount>();
            Car = new HashSet<Car>();
            PolicyNavigation = new HashSet<Policy>();
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Jmbg { get; set; }
        public string Phone { get; set; }
        public int ClientId { get; set; }
        public int? CtId { get; set; }
        public int? PolicyId { get; set; }

        public virtual ICollection<BankAccount> BankAccount { get; set; }
        public virtual ICollection<Car> Car { get; set; }
        public virtual ICollection<Policy> PolicyNavigation { get; set; }
        public virtual TypeOfClient Ct { get; set; }
        public virtual Policy Policy { get; set; }
    }
}
