using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface IContinentBLL
    {
        List<Continent> GetAll();
        int Add(Continent k);
    }
}
