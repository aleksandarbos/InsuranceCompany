using AspNetCoreSPA.EntityFramework;
using AspNetCoreSPA.Model.POCOs;
using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSPA.DAL
{
    public class SubjectOfInsuranceDAL : ISubjectOfInsuranceDAL
    {
        private readonly ApplicationDbContext _context;

        public SubjectOfInsuranceDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<SubjectOfInsurance> GetAll()
        {
            try
            {
                return _context.SubjectOfInsurance;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
