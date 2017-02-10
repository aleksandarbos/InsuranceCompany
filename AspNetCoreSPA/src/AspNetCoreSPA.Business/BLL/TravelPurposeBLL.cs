using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class TravelPurposeBLL : ITravelPurposeBLL
    {
        private readonly IRepository<TravelPurpose> _travelPurposeDAL;

        public TravelPurposeBLL(IRepository<TravelPurpose> travelPurposeDAL)
        {
            _travelPurposeDAL = travelPurposeDAL;
        }

        public List<TravelPurpose> GetAll()
        {
            try
            {
                return _travelPurposeDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
