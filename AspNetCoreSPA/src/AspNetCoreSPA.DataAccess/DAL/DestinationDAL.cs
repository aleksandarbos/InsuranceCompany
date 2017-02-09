using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class DestinationDAL : IDestinationDAL
    {
        private readonly ApplicationDbContext _context;

        public DestinationDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<Destination> GetAll()
        {
            try
            {
                return _context.Destination;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
