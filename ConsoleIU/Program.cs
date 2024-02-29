using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            CarManager carManager1 = new CarManager(new EfCarDal());
            //carManager1
            carManager1.AddedIf(new Car { CarId = 1, BrandId = 2, ColorId = 1, ModelYear = 2016, DailyPrice = 60200, Description = "İdare araba" });
            
        }
    }
}
