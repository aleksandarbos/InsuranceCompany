using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class RiskOfHouseBLL : IRiskOfHouseBLL
    {
        private readonly IRepository<RiskOfHouse> _riskOfHouseDAL;

        public RiskOfHouseBLL(IRepository<RiskOfHouse> riskOfHouseDAL)
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
