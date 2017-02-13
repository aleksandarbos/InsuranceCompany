using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class PricelistBLL : IPricelistBLL
    {
        private readonly IRepository<Pricelist> _pricelistDAL;

        public PricelistBLL(IRepository<Pricelist> pricelistDAL)
        {
            _pricelistDAL = pricelistDAL;
        }

        public int Add(Pricelist p)
        {
            throw new NotImplementedException();
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
