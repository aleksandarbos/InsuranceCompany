using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class RiskDAL : IRiskDAL
    {
        private readonly ApplicationDbContext _context;

        public RiskDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<Risk> GetAll()
        {
            try
            {
                return _context.Risk;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
