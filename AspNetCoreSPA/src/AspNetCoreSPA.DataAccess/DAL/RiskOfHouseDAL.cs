using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class RiskOfHouseDAL : IRiskOfHouseDAL
    {
        private readonly ApplicationDbContext _context;

        public RiskOfHouseDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<RiskOfHouse> GetAll()
        {
            try
            {
                return _context.RiskOfHouse;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
