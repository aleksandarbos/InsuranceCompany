using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface ICountryBLL
    {
        List<Country> GetAll();
        int Add(Country c);
    }
}
