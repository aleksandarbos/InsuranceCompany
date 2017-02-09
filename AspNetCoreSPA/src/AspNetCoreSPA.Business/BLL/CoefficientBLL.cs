using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class CoefficientBLL : ICoefficentBLL
    {
        private readonly ICoefficientDAL _coefficientDAL;

        public CoefficientBLL(ICoefficientDAL coefficientDAL)
        {
            _coefficientDAL = coefficientDAL;
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
