using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface ITypeOfPackageBLL
    {
        List<TypeOfPackage> GetAll();
        int Add(TypeOfPackage s);

    }
}
