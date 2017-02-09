using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class RiskOfCarDAL : IRiskOfCarDAL
    {
        private readonly ApplicationDbContext _context;

        public RiskOfCarDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<RiskOfCar> GetAll()
        {
            try
            {
                return _context.RiskOfCar;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
