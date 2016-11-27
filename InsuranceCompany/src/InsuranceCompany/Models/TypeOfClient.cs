using System;
using System.Collections.Generic;

namespace InsuranceCompany.Models
{
    public partial class TypeOfClient
    {
        public TypeOfClient()
        {
            Client = new HashSet<Client>();
        }

        public int CtId { get; set; }
        public string CtName { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
