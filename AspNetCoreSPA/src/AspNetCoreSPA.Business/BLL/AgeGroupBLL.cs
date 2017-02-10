using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class AgeGroupBLL : IAgeGroupBLL
    {
        private readonly IRepository<AgeGroup> _ageGroupDAL;

        public AgeGroupBLL(IRepository<AgeGroup> ageGroupDAL)
        {
            _ageGroupDAL = ageGroupDAL;
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
    }
}
