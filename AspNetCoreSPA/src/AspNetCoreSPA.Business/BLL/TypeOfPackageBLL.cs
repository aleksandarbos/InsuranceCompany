using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class TypeOfPackageBLL : ITypeOfPackageBLL
    {
        private readonly ITypeOfPackageDAL _typeOfPackageDAL;

        public TypeOfPackageBLL(ITypeOfPackageDAL typeOfPackageDAL)
        {
            _typeOfPackageDAL = typeOfPackageDAL;
        }

        public List<TypeOfPackage> GetAll()
        {
            try
            {
                return _typeOfPackageDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
