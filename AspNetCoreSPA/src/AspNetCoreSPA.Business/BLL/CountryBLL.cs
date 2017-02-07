using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class CountryBLL : ICountryBLL
    {
        private readonly ICountryDAL _countryDAL;

        public CountryBLL(ICountryDAL countryDAL)
        {
            _countryDAL = countryDAL;
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
