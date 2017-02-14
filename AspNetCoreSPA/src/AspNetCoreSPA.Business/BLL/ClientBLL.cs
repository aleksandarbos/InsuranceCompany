using AspNetCoreSPA.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class ClientBLL : IClientBLL
    {
        private readonly IRepository<Client> _clientDAL;
        public ClientBLL(IRepository<Client> policyDAL) {
            _clientDAL = policyDAL;
        }
        public int Add(Client cl)
        {
            _clientDAL.Create(cl);
            return cl.ClientId;
        }

        public List<Client> GetAll()
        {
           return  _clientDAL.GetAll().ToList();
        }
        
    }
}
