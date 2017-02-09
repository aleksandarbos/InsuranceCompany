using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.DAL
{
    public class PdvDAL : IPdvDAL
    {
        private readonly ApplicationDbContext _context;

        public PdvDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<Pdv> GetAll()
        {
            try
            {
                return _context.Pdv;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
