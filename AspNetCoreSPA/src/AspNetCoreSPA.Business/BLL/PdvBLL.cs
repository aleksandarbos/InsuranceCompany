using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class PdvBLL : IPdvBLL
    {
        private readonly IPdvDAL _pdvDAL;

        public PdvBLL(IPdvDAL pdvDAL)
        {
            _pdvDAL = pdvDAL;
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
