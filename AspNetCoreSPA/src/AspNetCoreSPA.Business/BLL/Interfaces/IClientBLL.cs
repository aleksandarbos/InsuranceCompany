using AspNetCoreSPA.Model.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSPA.BLL.Interfaces
{
    public interface IClientBLL
    {
        List<Client> GetAll();
        int Add(Client cl);
    }
}
