using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : ICarDal, IBrandDal, IColorDal
    {
        List<Car> _car;
        List<Brand> _brand;
        List<Color> _color;

        // VERİ LİSTELERİ OLUŞTURMA

        // CAR VERİ LİST
        public InMemoryDal()
        {
            _car = new List<Car>
            {
                new Car{CarId=1, BrandId=1,ColorId=1,DailyPrice=60000, Description="çok güzel araba", ModelYear=2015},
                new Car{CarId=2, BrandId=1,ColorId=1,DailyPrice=60500, Description="çok güzel araba", ModelYear=2016},
                new Car{CarId=3, BrandId=2,ColorId=2,DailyPrice=85000, Description="harika araba", ModelYear=2017},
                new Car{CarId=4, BrandId=2,ColorId=2,DailyPrice=50000, Description="güzel araba", ModelYear=2013},
                new Car{CarId=5, BrandId=3,ColorId=3,DailyPrice=110000, Description="harika ötesi araba", ModelYear=2024},
                new Car{CarId=6, BrandId=3,ColorId=3,DailyPrice=95000, Description="mükemmel araba", ModelYear=2022},
            };
        }

        // BRAND VERİ LİST
        public InMemoryDal(List<Brand> brand)
        {
            _brand = new List<Brand>
            {
                new Brand{BrandId=1, BrandName="Citroen"},
                new Brand{BrandId=2, BrandName="Wolsvagen"},
                new Brand{BrandId=3, BrandName="Audi"},
            };
        }

        // COLOR VERİ LİST
        public InMemoryDal(List<Color> color)
        {
            _color = new List<Color>
            {
                new Color{ColorId=1, ColorName="Siyah"},
                new Color{ColorId=2, ColorName="Beyaz"},
                new Color{ColorId=3, ColorName="Kırmızı"},
            };
        }

     

        //CAR İŞLEMLERİ
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetById(int brandid)
        {
            return _car.Where(c => c.BrandId == brandid).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.CarId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        // BRAND İŞLEMLERİ
        public void Add(Brand brand)
        {
            _brand.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brand.SingleOrDefault(b => b.BrandId == brand.BrandId);
            _brand.Remove(brandToDelete);
        }

        List<Brand> IBrandDal.GetAll()
        {
            return _brand;
        }
        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brand.SingleOrDefault(b => b.BrandId == brand.BrandId);
            brandToUpdate.BrandId = brand.BrandId;
            brandToUpdate.BrandName = brand.BrandName;
        }


        // COLOR İŞLEMLERİ
        public void Add(Color color)
        {
            _color.Add(color);
        }
        public void Delete(Color color)
        {
            Color colorToDelete = _color.SingleOrDefault(co => co.ColorId == color.ColorId);
            _color.Remove(colorToDelete);

        }

        public void Update(Color color)
        {
            Color colorToUpdate = _color.SingleOrDefault(co => co.ColorId == color.ColorId);
            colorToUpdate.ColorId = color.ColorId;
            colorToUpdate.ColorName = color.ColorName;

        }

        List<Color> IColorDal.GetAll()
        {
            return _color;
        }
    }
}
