using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface ITravelActivityTravelPurposeBLL
    {
        List<TravelActivityTravelPurpose> GetAll();
        int add(TravelActivityTravelPurpose t);
    }
}
