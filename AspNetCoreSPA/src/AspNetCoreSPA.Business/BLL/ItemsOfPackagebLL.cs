using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class ItemsOfPackageBLL : IItemsOfPackageBLL
    {
        private readonly IRepository<ItemsOfPackage> _itemsOfPackageDAL;

        public ItemsOfPackageBLL(IRepository<ItemsOfPackage> itemsOfPackageDAL)
        {
            _itemsOfPackageDAL = itemsOfPackageDAL;
        }

        public int Add(ItemsOfPackage i)
        {
            throw new NotImplementedException();
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
