using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class InsurancePackageBLL : IInsurancePackageBLL
    {
        private readonly IInsurancePackageDAL _insurancePackageDAL;

        public InsurancePackageBLL(IInsurancePackageDAL insurancePackageDAL)
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
