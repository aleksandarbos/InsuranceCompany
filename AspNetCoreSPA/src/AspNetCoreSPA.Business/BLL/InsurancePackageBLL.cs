using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class InsurancePackageBLL : IInsurancePackageBLL
    {
        private readonly IRepository<InsurancePackage> _insurancePackageDAL;

        public InsurancePackageBLL(IRepository<InsurancePackage> insurancePackageDAL)
        {
            _insurancePackageDAL = insurancePackageDAL;
        }

        public List<InsurancePackage> GetAll()
        {
            try
            {
                return _insurancePackageDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
