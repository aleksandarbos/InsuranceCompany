using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class CountryDAL : ICountryDAL
    {
        private readonly ApplicationDbContext _context;

        public CountryDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateCountry(Country country)
        {
            try
            {
                _context.Country.Add(country);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DbSet<Country> GetAll()
        {
            try
            {
                return _context.Country;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
