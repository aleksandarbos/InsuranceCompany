using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.DAL
{
    public class RateOfPdvDAL : IRateOfPdvDAL
    {
        private readonly ApplicationDbContext _context;

        public RateOfPdvDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<RateOfPdv> GetAll()
        {
            try
            {
                return _context.RateOfPdv;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
