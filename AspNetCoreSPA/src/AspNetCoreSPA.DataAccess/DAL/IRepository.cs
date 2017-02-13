using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSPA.DAL
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        DbSet<T> GetAll();
    }
}
