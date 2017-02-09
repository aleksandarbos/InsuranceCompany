using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class PolicyDAL : IPolicyDAL
    {
        private readonly ApplicationDbContext _context;

        public PolicyDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<Policy> GetAll()
        {
            try
            {
                return _context.Policy;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
