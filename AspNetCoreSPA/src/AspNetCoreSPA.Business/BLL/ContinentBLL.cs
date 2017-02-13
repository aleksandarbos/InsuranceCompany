using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class ContinentBLL : IContinentBLL
    {
        private readonly IRepository<Continent> _continentDAL;

        public ContinentBLL(IRepository<Continent> continentDAL)
        {
            _continentDAL = continentDAL;
        }

        public int Add(Continent k)
        {
            throw new NotImplementedException();
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
