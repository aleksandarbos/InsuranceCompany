using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class AgeGroupBLL : IAgeGroupBLL
    {
        private readonly IAgeGroupDAL _ageGroupDAL;

        public AgeGroupBLL(IAgeGroupDAL ageGroupDAL)
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
