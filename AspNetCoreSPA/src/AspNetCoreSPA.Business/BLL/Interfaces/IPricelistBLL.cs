using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface IPricelistBLL
    {
        List<Pricelist> GetAll();
        int add(Pricelist p);
    }
}
