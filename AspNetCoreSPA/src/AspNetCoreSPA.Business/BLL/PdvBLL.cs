using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class PdvBLL : IPdvBLL
    {
        private readonly IRepository<Pdv> _pdvDAL;

        public PdvBLL(IRepository<Pdv> pdvDAL)
        {
            _pdvDAL = pdvDAL;
        }

        public int Add(Pdv p)
        {
            throw new NotImplementedException();
        }

        public List<Pdv> GetAll()
        {
            try
            {
                return _pdvDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
