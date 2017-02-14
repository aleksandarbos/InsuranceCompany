using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class TypeOfPackageBLL : ITypeOfPackageBLL
    {
        private readonly IRepository<TypeOfPackage> _typeOfPackageDAL;

        public TypeOfPackageBLL(IRepository<TypeOfPackage> typeOfPackageDAL)
        {
            _typeOfPackageDAL = typeOfPackageDAL;
        }

        public int Add(TypeOfPackage s)
        {
            throw new NotImplementedException();
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
