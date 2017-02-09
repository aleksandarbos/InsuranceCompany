using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class HomeBLL : IHomeBLL
    {
        private readonly IHomeDAL _homeDAL;

        public HomeBLL(IHomeDAL homeDAL)
        {
            _homeDAL = homeDAL;
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
