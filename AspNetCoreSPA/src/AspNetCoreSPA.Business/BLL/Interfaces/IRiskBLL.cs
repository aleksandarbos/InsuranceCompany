using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface IRiskOfCarBLL
    {
        List<RiskOfCar> GetAll();
        int Add(RiskOfCar r);
    }
}
