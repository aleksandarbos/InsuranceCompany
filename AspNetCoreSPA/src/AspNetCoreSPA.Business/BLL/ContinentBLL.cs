using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class ContinentBLL : IContinentBLL
    {
        private readonly IContinentDAL _continentDAL;

        public ContinentBLL(IContinentDAL continentDAL)
        {
            _continentDAL = continentDAL;
        }

        public List<Continent> GetAll()
        {
            try
            {
                return _continentDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
