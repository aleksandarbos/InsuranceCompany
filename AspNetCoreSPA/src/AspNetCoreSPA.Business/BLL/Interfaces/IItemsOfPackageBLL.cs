using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface IItemsOfPackageBLL
    {
        List<ItemsOfPackage> GetAll();
        int Add(ItemsOfPackage i);
    }
}
