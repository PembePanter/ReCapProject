using Business.Abstract;
using Business.Constants;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental entity)
        {
            var result = _rentalDal.GetAll(r => r.CarId == entity.CarId);
            foreach (var rental in result)
            {
                if (rental.ReturnDate == null)
                {
                    return new ErrorResult(ErrorMessages.CarIsNotReturned);
                }
            }
            _rentalDal.Add(entity);
            return new SuccessResult(CRUDMessages.RentalAdded);
        }

        public IResult Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new SuccessResult(CRUDMessages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            _rentalDal.GetAll();
            return new SuccessDataResult<List<Rental>>(CRUDMessages.RentalsListed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            _rentalDal.Get(r => r.Id == id);
            return new SuccessDataResult<Rental>(CRUDMessages.RentalsListed);
        }

        public IResult Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessResult(CRUDMessages.RentalUpdated);
        }
    }
}
