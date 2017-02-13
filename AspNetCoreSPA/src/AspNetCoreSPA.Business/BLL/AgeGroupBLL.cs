

using System;
using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;
using System.Linq;

namespace AspNetCoreSPA.BLL
{
    public class AgeGroupBLL : IAgeGroupBLL
    {
        private readonly IRepository<AgeGroup> _ageGroupDAL;

        public AgeGroupBLL(IRepository<AgeGroup> ageGroupDAL)
        {
            _ageGroupDAL = ageGroupDAL;
        }

        public int Add(AgeGroup a)
        {
            throw new NotImplementedException();
        }

        public List<AgeGroup> GetAll()
        {
            try
            {
                return _ageGroupDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<AgeGroup> IAgeGroupBLL.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
