using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface ISubjectOfInsurnaceBLL
    {
        List<SubjectOfInsurance> GetAll();
    }
}
