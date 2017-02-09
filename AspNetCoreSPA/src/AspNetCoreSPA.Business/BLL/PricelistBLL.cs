using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class PricelistBLL : IPricelistBLL
    {
        private readonly IPricelistDAL _pricelistDAL;

        public PricelistBLL(IPricelistDAL pricelistDAL)
        {
            _pricelistDAL = pricelistDAL;
        }

        public List<Pricelist> GetAll()
        {
            try
            {
                return _pricelistDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
