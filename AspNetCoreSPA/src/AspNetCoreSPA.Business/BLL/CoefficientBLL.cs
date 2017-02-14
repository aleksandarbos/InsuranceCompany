using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class CoefficientBLL : ICoefficientBLL
    {
        private readonly IRepository<Coefficient> _coefficientDAL;

        public CoefficientBLL(IRepository<Coefficient> coefficientDAL)
        {
            _coefficientDAL = coefficientDAL;
        }

        public int Add(Coefficient c)
        {
            throw new NotImplementedException();
        }

        public List<Coefficient> GetAll()
        {
            try
            {
                return _coefficientDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
