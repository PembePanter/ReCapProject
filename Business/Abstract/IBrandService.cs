using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IBrandService : IServiceRepository<Brand>
    {
        IDataResult<List<Brand>> GetBrandById(int brandId);
    }
}
