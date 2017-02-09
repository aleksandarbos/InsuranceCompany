using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class CarDAL : ICarDAL
    {
        private readonly ApplicationDbContext _context;

        public CarDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<Car> GetAll()
        {
            try
            {
                return _context.Car;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
