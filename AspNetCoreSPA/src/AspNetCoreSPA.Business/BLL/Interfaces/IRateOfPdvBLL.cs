using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface IRateOfPdvBLL
    {
        List<RateOfPdv> GetAll();
        int Add(RateOfPdv a);
    }
}
