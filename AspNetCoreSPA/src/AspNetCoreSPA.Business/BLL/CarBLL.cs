using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class CarBLL : ICarBLL
    {
        private readonly ICarDAL _carDAL;

        public CarBLL(ICarDAL carDAL)
        {
            _carDAL = carDAL;
        }

        public List<Car> GetAll()
        {
            try
            {
                return _carDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
