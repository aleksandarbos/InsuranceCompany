using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class TravelActivityTravelPurposeBLL : ITravelActivityTravelPurposeBLL
    {
        private readonly IRepository<TravelActivityTravelPurpose> _travelActivityTravelPurposeDAL;

        public TravelActivityTravelPurposeBLL(IRepository<TravelActivityTravelPurpose> travelActivityTravelPurposeDAL)
        {
            _travelActivityTravelPurposeDAL = travelActivityTravelPurposeDAL;
        }

        public int Add(TravelActivityTravelPurpose t)
        {
            throw new NotImplementedException();
        }

        public List<TravelActivityTravelPurpose> GetAll()
        {
            try
            {
                return _travelActivityTravelPurposeDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
