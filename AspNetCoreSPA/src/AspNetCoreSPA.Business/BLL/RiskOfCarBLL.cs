using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class RiskOfCarBLL : IRiskOfCarBLL
    {
        private readonly IRepository<RiskOfCar> _riskOfCarDAL;

        public RiskOfCarBLL(IRepository<RiskOfCar> riskOfCarDAL)
        {
            _riskOfCarDAL = riskOfCarDAL;
        }

        public int Add(RiskOfCar r)
        {
            _riskOfCarDAL.Create(r);
            return r.RocId;
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
