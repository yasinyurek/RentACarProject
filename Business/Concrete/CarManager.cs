using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        // Listeleme Fonksiyonları
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        
        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetByModelYear(int modelYear)
        {
            return _carDal.GetAll(c => c.ModelYear == modelYear);
        }


        // Emir Fonsiyonları (Ekleme Çıkarma vs)
        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.CarModelName.Length >= 2)
            {
                _carDal.Add(car);
            }
            else
            {
                if (car.DailyPrice == 0)
                {
                    Console.WriteLine($"Lütfen günlük fiyat kısmını 0'dan büyük giriniz! Girdiğiniz fiyat : {car.DailyPrice}");
                }
                if (car.CarModelName.Length <= 2)
                {
                    Console.WriteLine($"Araba ismi minimum 2 karakter olmalıdır!  Girdiğiniz isim :{car.CarModelName}");
                }

            }
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Araba sistemde basariyla guncellendi.");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba sistemden basariyla silindi.");
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
