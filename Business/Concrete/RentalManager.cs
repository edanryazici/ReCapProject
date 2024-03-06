using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Constans;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager: IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.RentDate!= null)
            {
                return new ErrorResult(Messages.RentalAddedError);
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAddedSuccess);
        }

        public IDataResult<List<RentalDetailDto>> GetAll()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }
    }
}
