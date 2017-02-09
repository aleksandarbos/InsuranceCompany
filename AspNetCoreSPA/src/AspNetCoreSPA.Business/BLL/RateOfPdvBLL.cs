using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class RateOfPdvBLL : IRateOfPdvBLL
    {
        private readonly IRateOfPdvDAL _rateOfPdvDAL;

        public RateOfPdvBLL(IRateOfPdvDAL rateOfPdvDAL)
        {
            _rateOfPdvDAL = rateOfPdvDAL;
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
