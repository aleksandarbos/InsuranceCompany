using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class SubjectOfInsuranceBLL : ISubjectOfInsurnaceBLL
    {
        private readonly ISubjectOfInsuranceDAL _subjectOfInsuranceDAL;

        public SubjectOfInsuranceBLL(ISubjectOfInsuranceDAL subjectOfInsuranceDAL)
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
