using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class SubjectOfInsuranceBLL : ISubjectOfInsuranceBLL
    {
        private readonly IRepository<SubjectOfInsurance> _subjectOfInsuranceDAL;

        public SubjectOfInsuranceBLL(IRepository<SubjectOfInsurance> subjectOfInsuranceDAL)
        {
            _subjectOfInsuranceDAL = subjectOfInsuranceDAL;
        }

        public List<SubjectOfInsurance> GetAll()
        {
            try
            {
                return _subjectOfInsuranceDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
