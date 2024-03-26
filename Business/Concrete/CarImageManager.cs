using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        ICarService _carService;

        public CarImageManager(ICarImageDal carImageDal, ICarService carService)
        {
            _carImageDal = carImageDal;
            _carService = carService;
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfImageCountNumber(carImage.CarId));
            if (result!=null)
            {
                return result;
            }

            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfImageCountNumber(carImage.CarId));
            if (result != null)
            {
                return result;
            }

            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageUpdate);
        }

        private IResult CheckIfImageCountNumber(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId==carId).Count;
            if (result>5)
            {
                return new ErrorResult(Messages.ImageCountLimitError);
            }

            return new SuccessResult();
        }

       //private IResult CheckIfSelectImage(int carId, CarImage carImage)
       // {
       //     var result = _carImageDal.GetAll(c=>c.CarId==carId).Any();
       //     if (result && carImage.ImageName==null)
       //     {

       //     }
       // } BURASI KALSIN HOCAYLA YAPALIM
    }
}
