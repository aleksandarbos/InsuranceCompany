using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.DAL
{
    public class CoefficientDAL : ICoefficientDAL
    {
        private readonly ApplicationDbContext _context;

        public CoefficientDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<Coefficient> GetAll()
        {
            try
            {
                return _context.Coefficient;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
