using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class PolicyBLL : IPolicyBLL
    {
        private readonly IRepository<Policy> _policyDAL;

        public PolicyBLL(IRepository<Policy> policyDAL)
        {
            _policyDAL = policyDAL;
        }

        public List<Policy> GetAll()
        {
            try
            {
                return _policyDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
