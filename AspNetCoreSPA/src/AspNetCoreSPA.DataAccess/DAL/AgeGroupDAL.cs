using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class AgeGroupDAL : IAgeGroupDAL
    {
        private readonly ApplicationDbContext _context;

        public AgeGroupDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<AgeGroup> GetAll()
        {
            try
            {
                return _context.AgeGroup;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
