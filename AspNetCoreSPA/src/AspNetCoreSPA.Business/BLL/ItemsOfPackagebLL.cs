using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class ItemsOfPackageBLL : IItemsOfPackageBLL
    {
        private readonly IItemsOfPackageDAL _itemsOfPackageDAL;

        public ItemsOfPackageBLL(IItemsOfPackageDAL itemsOfPackageDAL)
        {
            _itemsOfPackageDAL = itemsOfPackageDAL;
        }

        public List<ItemsOfPackage> GetAll()
        {
            try
            {
                return _itemsOfPackageDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
