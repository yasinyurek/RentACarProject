using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById( int id);
        List<Car> GetByColor( int colorId);
        List<Car> GetByBrandId( int brandId);
        List<Car> GetByDailyPrice( int dailyPrice);
        List<Car> GetByModelYear( int modelYear);


        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

       

    }
}
