using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class RiskBLL : IRiskBLL
    {
        private readonly IRepository<Risk> _riskDAL;

        public RiskBLL(IRepository<Risk> riskDAL)
        {
            _riskDAL = riskDAL;
        }

        public int Add(Risk r)
        {
            throw new NotImplementedException();
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
