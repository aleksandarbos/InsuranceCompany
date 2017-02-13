using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface IHomeBLL
    {
        List<Home> GetAll();
        int add(Home h);
    }
}
