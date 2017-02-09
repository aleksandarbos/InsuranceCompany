using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class PolicyBLL : IPolicyBLL
    {
        private readonly IPolicyDAL _policyDAL;

        public PolicyBLL(IPolicyDAL policyDAL)
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
