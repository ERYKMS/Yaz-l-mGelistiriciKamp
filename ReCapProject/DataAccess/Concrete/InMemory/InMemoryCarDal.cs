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
            _cars = new List<Car> { new Car { Id=1,BrandId=1,ColorId=1,DailyPrice=123,Description="",ModelYear=2022},
                new Car { Id=2,BrandId=2,ColorId=2,DailyPrice=234,Description=" ",ModelYear=2002 },
                new Car { Id=3,BrandId=3,ColorId=3,DailyPrice=345,Description=" ",ModelYear=2023 }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDeleted =_cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDeleted);
        }

        public List<Car> GetByAll()
        {
            return _cars;
        }

        public List<Car> GetByAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetByID(int id)
        {
            Car carGetedById= _cars.SingleOrDefault(c => c.Id == id);
            return carGetedById;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=> c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Id = car.Id;
        }
    }
}
