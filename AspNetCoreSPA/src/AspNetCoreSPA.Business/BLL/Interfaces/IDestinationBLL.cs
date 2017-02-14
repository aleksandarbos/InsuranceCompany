using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface IDestinationBLL
    {
        List<Destination> GetAll();
        int Add(Destination d);
    }
}
