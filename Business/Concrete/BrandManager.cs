using Business.Abstract;
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

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete (brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetBrandById(int id)
        {
            return _brandDal.GetAll(b=> b.Id == id);
        }

        public List<Brand> GetBrandByName(string name)
        {
            return _brandDal.GetAll(b=> b.Name == name);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
