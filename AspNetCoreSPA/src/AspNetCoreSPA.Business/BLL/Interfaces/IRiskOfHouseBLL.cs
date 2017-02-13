using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface IRiskOfHouseBLL
    {
        List<RiskOfHouse> GetAll();
        int add(RiskOfHouse r);
    }
}
