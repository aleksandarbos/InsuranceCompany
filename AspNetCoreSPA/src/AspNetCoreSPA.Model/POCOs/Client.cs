using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class Client
    {
        public Client()
        {
            Car = new HashSet<Car>();
            PolicyNavigation = new HashSet<Policy>();
        }

        public int ClientId { get; set; }
        public int? AgId { get; set; }
        public int? PolicyId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Jmbg { get; set; }
        public string Phone { get; set; }
        public decimal? PassportNumber { get; set; }
        public string Sex { get; set; }

        public virtual ICollection<Car> Car { get; set; }
        public virtual ICollection<Policy> PolicyNavigation { get; set; }
        public virtual AgeGroup Ag { get; set; }
        public virtual Policy Policy { get; set; }
    }
}
