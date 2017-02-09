using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class HomeDAL : IHomeDAL
    {
        private readonly ApplicationDbContext _context;

        public HomeDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<Home> GetAll()
        {
            try
            {
                return _context.Home;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
