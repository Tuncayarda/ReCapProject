using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1, BrandId=1, ColorId=1, ModelYear="2000", DailyPrice=20, Description="car #1"},
                new Car {Id=2, BrandId=1, ColorId=3, ModelYear="2001", DailyPrice=40, Description="car #2"},
                new Car {Id=3, BrandId=2, ColorId=5, ModelYear="2002", DailyPrice=60, Description="car #3"},
                new Car {Id=4, BrandId=2, ColorId=7, ModelYear="2003", DailyPrice=80, Description="car #4"},
                new Car {Id=5, BrandId=3, ColorId=8, ModelYear="2004", DailyPrice=100, Description="car #5"},
                new Car {Id=6, BrandId=3, ColorId=8, ModelYear="2005", DailyPrice=120, Description="car #6"},
                new Car {Id=7, BrandId=4, ColorId=6, ModelYear="2006", DailyPrice=140, Description="car #7"},
                new Car {Id=8, BrandId=4, ColorId=5, ModelYear="2007", DailyPrice=160, Description="car #8"},
                new Car {Id=9, BrandId=5, ColorId=4, ModelYear="2008", DailyPrice=180, Description="car #9"},
                new Car {Id=10, BrandId=5, ColorId=1, ModelYear="2009", DailyPrice=200, Description="car #10"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(p => p.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
