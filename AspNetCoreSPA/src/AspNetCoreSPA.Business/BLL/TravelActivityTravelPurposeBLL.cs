using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class TravelActivityTravelPurposeBLL : ITravelActivityTravelPurposeBLL
    {
        private readonly ITravelActivityTravelPurposeDAL _travelActivityTravelPurposeDAL;

        public TravelActivityTravelPurposeBLL(ITravelActivityTravelPurposeDAL travelActivityTravelPurposeDAL)
        {
            _travelActivityTravelPurposeDAL = travelActivityTravelPurposeDAL;
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
