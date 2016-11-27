using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Policy = new HashSet<Policy>();
        }

        public int EnId { get; set; }
        public int RoleId { get; set; }
        public int? CpId { get; set; }
        public string EnFirstname { get; set; }
        public string EnLastname { get; set; }

        public virtual ICollection<Policy> Policy { get; set; }
        public virtual InsuranceCompany Cp { get; set; }
        public virtual EmployeeRole Role { get; set; }
    }
}
