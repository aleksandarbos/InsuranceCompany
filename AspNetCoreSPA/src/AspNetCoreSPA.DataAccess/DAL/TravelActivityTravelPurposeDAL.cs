using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class TravelActivityTravelPurposeDAL : ITravelActivityTravelPurposeDAL
    {
        private readonly ApplicationDbContext _context;

        public TravelActivityTravelPurposeDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<TravelActivityTravelPurpose> GetAll()
        {
            try
            {
                return _context.TravelActivityTravelPurpose;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
