using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class Car
    {
        public Car()
        {
            SubjectOfInsurance = new HashSet<SubjectOfInsurance>();
        }

        public int Carid { get; set; }
        public int ClientId { get; set; }
        public DateTime? Year { get; set; }
        public int? ChassisNumber { get; set; }
        public string LicencePlate { get; set; }
        public string CarType { get; set; }
        public string CarModel { get; set; }

        public virtual ICollection<SubjectOfInsurance> SubjectOfInsurance { get; set; }
        public virtual Client Client { get; set; }
    }
}
