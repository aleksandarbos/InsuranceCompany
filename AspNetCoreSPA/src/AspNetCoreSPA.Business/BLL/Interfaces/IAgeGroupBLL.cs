using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface IAgeGroupBLL
    {
        List<AgeGroup> GetAll();
        int Add(AgeGroup a);
    }
}
