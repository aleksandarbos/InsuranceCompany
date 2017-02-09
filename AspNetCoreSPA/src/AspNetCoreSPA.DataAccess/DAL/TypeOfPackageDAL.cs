using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class TypeOfPackageDAL : ITypeOfPackageDAL
    {
        private readonly ApplicationDbContext _context;

        public TypeOfPackageDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<TypeOfPackage> GetAll()
        {
            try
            {
                return _context.TypeOfPackage;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
