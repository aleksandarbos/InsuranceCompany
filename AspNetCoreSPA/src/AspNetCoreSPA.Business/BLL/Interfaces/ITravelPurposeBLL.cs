using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface ITravelPurposeBLL
    {
        List<TravelPurpose> GetAll();
    }
}
