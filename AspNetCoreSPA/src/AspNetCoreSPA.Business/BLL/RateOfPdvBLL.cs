using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class RateOfPdvBLL : IRateOfPdvBLL
    {
        private readonly IRepository<RateOfPdv> _rateOfPdvDAL;

        public RateOfPdvBLL(IRepository<RateOfPdv> rateOfPdvDAL)
        {
            _rateOfPdvDAL = rateOfPdvDAL;
        }

        public int Add(RateOfPdv a)
        {
            throw new NotImplementedException();
        }

        public List<RateOfPdv> GetAll()
        {
            try
            {
                return _rateOfPdvDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
