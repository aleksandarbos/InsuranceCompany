using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class InsurancePackageDAL : IInsurancePackageDAL
    {
        private readonly ApplicationDbContext _context;

        public InsurancePackageDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<InsurancePackage> GetAll()
        {
            try
            {
                return _context.InsurancePackage;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
