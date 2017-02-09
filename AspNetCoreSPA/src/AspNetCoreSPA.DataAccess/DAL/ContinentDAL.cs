using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class ContinentDAL : IContinentDAL
    {
        private readonly ApplicationDbContext _context;

        public ContinentDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<Continent> GetAll()
        {
            try
            {
                return _context.Continent;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
