using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class DestinationBLL : IDestinationBLL
    {
        private readonly IRepository<Destination> _destinationDAL;

        public DestinationBLL(IRepository<Destination> destinationDAL)
        {
            _destinationDAL = destinationDAL;
        }

        public int Add(Destination d)
        {
            _destinationDAL.Create(d);
            return d.DstId;
        }

        public List<Destination> GetAll()
        {
            try
            {
                return _destinationDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
