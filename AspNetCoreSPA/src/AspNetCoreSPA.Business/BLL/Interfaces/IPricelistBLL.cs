using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface IPricelistBLL
    {
        List<Pricelist> GetAll();
        int Add(Pricelist p);
    }
}
