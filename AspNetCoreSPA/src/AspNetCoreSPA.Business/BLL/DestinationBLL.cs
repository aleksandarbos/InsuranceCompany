using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class DestinationBLL : IDestinationBLL
    {
        private readonly IDestinationDAL _destinationDAL;

        public DestinationBLL(IDestinationDAL destinationDAL)
        {
            _destinationDAL = destinationDAL;
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
