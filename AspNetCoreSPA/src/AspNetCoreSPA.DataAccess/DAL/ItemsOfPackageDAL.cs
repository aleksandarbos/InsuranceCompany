using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class ItemsOfPackageDAL : IItemsOfPackageDAL
    {
        private readonly ApplicationDbContext _context;

        public ItemsOfPackageDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<ItemsOfPackage> GetAll()
        {
            try
            {
                return _context.ItemsOfPackage;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
