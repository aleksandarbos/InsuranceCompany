using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface IPdvBLL
    {
        List<Pdv> GetAll();
        int add(Pdv p);
    }
}
