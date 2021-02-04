using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetBrandById(int id);
        List<Brand> GetBrandByName(string name);
        void Add(Brand brand);
        void Delete(Brand brand);
        void Update(Brand brand);
    }
}
