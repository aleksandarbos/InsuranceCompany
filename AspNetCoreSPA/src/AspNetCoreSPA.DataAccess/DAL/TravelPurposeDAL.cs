using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class TravelPurposeDAL : ITravelPurposeDAL
    {
        private readonly ApplicationDbContext _context;

        public TravelPurposeDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<TravelPurpose> GetAll()
        {
            try
            {
                return _context.TravelPurpose;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
