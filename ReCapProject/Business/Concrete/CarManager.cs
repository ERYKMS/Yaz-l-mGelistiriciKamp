using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void addCar(Car car)
        {
            if (car.BrandId >= 2 && car.DailyPrice > 0)
            {
               _carDal.Add(car);
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetByAll();
        }

        public List<Car> GetBGetCarsByBrandId(int id)
        {
            return _carDal.GetByAll(p => p.BrandId == id);

        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetByAll(p=>p.ColorId == id);
        }
    }
}
