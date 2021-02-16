using Core.Entities;
using Core.Services;
using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService : IServiceRepository<Brand>, IService<Brand>
    {
    }
}

//System.ArgumentException: 'Cannot instantiate implementation type
//'Business.Abstract.IBrandService' for service type 'Core.Services.IServiceRepository`1[Entities.Brand]'.'
