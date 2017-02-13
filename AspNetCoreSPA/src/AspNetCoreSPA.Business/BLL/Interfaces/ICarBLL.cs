using System.Collections.Generic;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.BLL
{
    public interface ICarBLL
    {
        List<Car> GetAll();
        int Add(Car c);
    }
}
