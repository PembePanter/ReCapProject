using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IBrandService : IServiceRepository<Brand>
    {
        List<Brand> GetBrandById(int id);
        List<Brand> GetBrandByName(string name);
    }
}
