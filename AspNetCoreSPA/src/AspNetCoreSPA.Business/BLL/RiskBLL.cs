using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class RiskBLL : IRiskBLL
    {
        private readonly IRiskDAL _riskDAL;

        public RiskBLL(IRiskDAL riskDAL)
        {
            _riskDAL = riskDAL;
        }

        public List<Risk> GetAll()
        {
            try
            {
                return _riskDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
