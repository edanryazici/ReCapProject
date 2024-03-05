using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByBrandId(int brandId);
        IDataResult<List<Car>> GetByColorId(int coloId);
        IDataResult<Car> GetById(int productId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car); 
        
        
    }
}
