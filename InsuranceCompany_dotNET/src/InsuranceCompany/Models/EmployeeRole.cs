using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class EmployeeRole
    {
        public EmployeeRole()
        {
            Employee = new HashSet<Employee>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
