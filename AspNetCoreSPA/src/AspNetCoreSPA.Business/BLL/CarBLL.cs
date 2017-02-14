

using AspNetCoreSPA.DAL;
using AspNetCoreSPA.Model.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreSPA.BLL
{
    public class CarBLL : ICarBLL
    {
        private readonly IRepository<Car> _carDAL;

        public CarBLL(IRepository<Car> carDAL)
        {
            _carDAL = carDAL;
        }

        public int Add(Car c)
        {
            _carDAL.Create(c);
            return c.Carid;
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
