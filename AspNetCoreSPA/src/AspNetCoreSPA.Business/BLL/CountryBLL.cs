using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class CountryBLL : ICountryBLL
    {
        private readonly IRepository<Country> _countryDAL;

        public CountryBLL(IRepository<Country> countryDAL)
        {
            _countryDAL = countryDAL;
        }

        public int Add(Country c)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAll()
        {
            try
            {
                return _countryDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
