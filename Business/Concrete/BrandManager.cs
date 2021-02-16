using Business.Abstract;
using Business.Constants;
using Core.Services;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(CRUDMessages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(CRUDMessages.BrandDeleted);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(CRUDMessages.BrandUpdated);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), CRUDMessages.BrandsListed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            _brandDal.Get(b => b.BrandId == id);
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == id));
        }
    }
}
