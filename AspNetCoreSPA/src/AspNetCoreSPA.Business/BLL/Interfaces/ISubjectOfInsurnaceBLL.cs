using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface ISubjectOfInsuranceBLL
    {
        List<SubjectOfInsurance> GetAll();
        int Add(SubjectOfInsurance s);
    }
}
