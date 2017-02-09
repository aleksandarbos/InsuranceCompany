using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class PricelistDAL : IPricelistDAL
    {
        private readonly ApplicationDbContext _context;

        public PricelistDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<Pricelist> GetAll()
        {
            try
            {
                return _context.Pricelist;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
