using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>()
            {
                new Car(){Id= 1,BrandId= 101,ColorId= 1001, ModelYear=2020, DailyPrice= 500000, Description= "Mercedes Amg GT, Otomatik Vites"},
                new Car(){Id= 2,BrandId= 201,ColorId= 2001, ModelYear=2005, DailyPrice= 50000, Description= "Audi A5, Manuel Vites"},
                new Car(){Id= 3,BrandId= 301,ColorId= 3001, ModelYear=2000, DailyPrice= 5000, Description= "Tofaş Doğan, Manuel"},
                new Car(){Id= 4,BrandId= 401,ColorId= 4001, ModelYear=2021, DailyPrice= 800000, Description= "Jeep, Otomatik Vites"}

            };
        }       
         

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }
        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColor(int colorId)
        {
            return _car.Where(c => c.ColorId == colorId).ToList();

        }

        public List<Car> GetByDailyPrice(int dailyPrice)
        {
            return _car.Where(c => c.DailyPrice == dailyPrice).ToList();
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.Id == id).ToList();
        }

        public List<Car> GetByModelYear(int modelYear)
        {
            return _car.Where(c => c.ModelYear == modelYear).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }

      
    }
}
