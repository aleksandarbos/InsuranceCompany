using AspNetCoreSPA.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class Repository<T> : IRepository<T> where T : class //Repository<T>
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            this._context = context;
        }
   
        public void CreateCountry(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DbSet<T> GetAll()
        {
            try
            {
                return _context.Set<T>();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
