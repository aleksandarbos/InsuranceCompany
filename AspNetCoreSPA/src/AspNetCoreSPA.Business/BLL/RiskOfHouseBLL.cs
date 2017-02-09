using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class RiskOfHouseBLL : IRiskOfHouseBLL
    {
        private readonly IRiskOfHouseDAL _riskOfHouseDAL;

        public RiskOfHouseBLL(IRiskOfHouseDAL riskOfHouseDAL)
        {
            _riskOfHouseDAL = riskOfHouseDAL;
        }

        public List<RiskOfHouse> GetAll()
        {
            try
            {
                return _riskOfHouseDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
