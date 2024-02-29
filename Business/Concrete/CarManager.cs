using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void AddedIf(Car entity)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                try
                {
                    if (entity.Description.Length > 2 && entity.DailyPrice > 0)
                    {
                        var addedIfEntity = context.Entry(entity);
                        addedIfEntity.State = EntityState.Added;
                        context.SaveChanges();
                        Console.WriteLine("Ekleme Başarılı!");
                    }
                    else
                    {
                        Console.WriteLine("Ekleme Başarısız! Araba açıklaması 2 karakterden uzun olmalı ve günlük fiyat pozitif bir değer olmalıdır.");
                    }
                }
                catch (DbUpdateException ex)
                {
                    Console.WriteLine("Veritabanına kayıt sırasında bir hata oluştu: " + ex.InnerException.Message);
                }
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Car> GetByColorId(int coloId)
        {
            return _carDal.GetAll(p => p.ColorId == coloId);
        }
    }
}
