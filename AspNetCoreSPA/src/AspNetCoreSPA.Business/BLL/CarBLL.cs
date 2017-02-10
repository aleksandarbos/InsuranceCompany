using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreSPA.Model.POCOs;
using AspNetCoreSPA.DAL;

namespace AspNetCoreSPA.BLL
{
    public class CarBLL : ICarBLL
    {
        private readonly IRepository<Car> _carDAL;

        public CarBLL(IRepository<Car> carDAL)
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
