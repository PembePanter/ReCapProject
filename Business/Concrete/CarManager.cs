using Business.Abstract;
using Business.Constants;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess;
using DataAccess.Concrete.InMemory;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length < 2)
            {
                return new ErrorResult(ErrorMessages.CarNameInvalid);
            }
            else
            {
                if (car.DailyPrice < 1)
                {
                    return new ErrorResult(ErrorMessages.InsufficientCarPrice);
                }
                else
                {
                    _carDal.Add(car);
                    return new SuccessResult(CRUDMessages.CarAdded);
                }
            }
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(CRUDMessages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(CRUDMessages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),CRUDMessages.CarsListed);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=> c.CarId == id));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=> c.BrandId == brandId), CRUDMessages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId), CRUDMessages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
    }
}
