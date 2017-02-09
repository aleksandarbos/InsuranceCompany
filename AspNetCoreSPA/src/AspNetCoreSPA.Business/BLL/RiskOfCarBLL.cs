using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class RiskOfCarBLL : IRiskOfCarBLL
    {
        private readonly IRiskOfCarDAL _riskOfCarDAL;

        public RiskOfCarBLL(IRiskOfCarDAL riskOfCarDAL)
        {
            _riskOfCarDAL = riskOfCarDAL;
        }

        public List<RiskOfCar> GetAll()
        {
            try
            {
                return _riskOfCarDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
