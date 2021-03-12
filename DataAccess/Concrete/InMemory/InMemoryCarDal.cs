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
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{ CarId=1, BrandId=1, ColorId="255,0,0", DailyPrice=180000, Description="Renault Captur", ModelYear=2015},
                new Car{ CarId=2, BrandId=1, ColorId="160,247,9", DailyPrice=250000, Description="Renault Captur", ModelYear=2016},
                new Car{ CarId=3, BrandId=1, ColorId="255,0,255", DailyPrice=340000, Description="Renault Talisman ", ModelYear=2018},
                new Car{ CarId=4, BrandId=1, ColorId="0,0,0", DailyPrice=520000, Description="Renault Talisman", ModelYear=2020},
                new Car{ CarId=5, BrandId=2, ColorId="255,170,170", DailyPrice=173500, Description="Honda Civic", ModelYear=2012},
                new Car{ CarId=6, BrandId=2, ColorId="255,212,170", DailyPrice=240000, Description="Honda Civic", ModelYear=2017},
                new Car{ CarId=7, BrandId=3, ColorId="0,0,0", DailyPrice=258900, Description="Wolksvagen Caddy", ModelYear=2021},
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars; // hepsini getirmesini istediğim için veritabanının hepsini burada dönüyorum.
        }

        public List<Car> GetById(int categoryId)
        {
            return _cars;
                
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;

        }
    }
}
