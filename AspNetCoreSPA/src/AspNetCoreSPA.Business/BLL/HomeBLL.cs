using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class HomeBLL : IHomeBLL
    {
        private readonly IRepository<Home> _homeDAL;

        public HomeBLL(IRepository<Home> homeDAL)
        {
            _homeDAL = homeDAL;
        }

        public int Add(Home h)
        {
            _homeDAL.Create(h);
            return h.HomeId;
        }

        public List<Home> GetAll()
        {
            try
            {
                return _homeDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
