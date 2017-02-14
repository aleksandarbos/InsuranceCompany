using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface ICoefficientBLL
    {
        List<Coefficient> GetAll();
        int Add(Coefficient c);
    }
}
