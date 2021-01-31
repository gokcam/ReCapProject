using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemory : ICarDal
    {
        List<Car> _cars;
        public InMemory()
        {
            _cars = new List<Car>
        {
            new Car{CarId=1,BrandId=1,ColorId=3,ModelYear=2021,DailyPrice=5000,Description="Ferrari"},
            new Car{CarId=2,BrandId=2,ColorId=1,ModelYear=2005,DailyPrice=250,Description="Honda"},
            new Car{CarId=3,BrandId=3,ColorId=2,ModelYear=2014,DailyPrice=700,Description="Volkswagen"},
            new Car{CarId=4,BrandId=4,ColorId=4,ModelYear=2016,DailyPrice=800,Description="Toyota"},
            new Car{CarId=5,BrandId=5,ColorId=5,ModelYear=2008,DailyPrice=1000,Description="BMW"},

        };

        }

        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car CarDelete = _cars.SingleOrDefault(c=>c.CarId== car.CarId);
            _cars.Remove(CarDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car CarUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarUpdate.ColorId = car.ColorId;
            CarUpdate.Description = car.Description;
            CarUpdate.DailyPrice = car.DailyPrice;
           
        }
    }
}
