using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class City
    {
        public City()
        {
            InsuranceCompany = new HashSet<InsuranceCompanyModel>();
        }

        public int CityId { get; set; }
        public int StId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<InsuranceCompanyModel> InsuranceCompany { get; set; }
        public virtual StateOfOrigin St { get; set; }
    }
}
