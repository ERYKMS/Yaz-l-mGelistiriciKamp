// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;



CarManager carManager =new CarManager(new EfCarDal());
var liste=carManager.GetBGetCarsByBrandId(1);

for (int i = 0; i < liste.Count; i++)
{
    Console.WriteLine(liste[i].Description);
}
Car bmw = new Car { Id = 2, BrandId = 3, Description = "BMW", ColorId = 5, DailyPrice = 5, ModelYear = 2002 };
carManager.addCar(bmw);
var liste2 = carManager.GetBGetCarsByBrandId(3);
foreach (var item in liste2)
{
    Console.WriteLine(item.Description);
}
