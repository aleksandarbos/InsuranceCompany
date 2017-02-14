using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface ITravelActivityTravelPurposeBLL
    {
        List<TravelActivityTravelPurpose> GetAll();
        int Add(TravelActivityTravelPurpose t);
    }
}
