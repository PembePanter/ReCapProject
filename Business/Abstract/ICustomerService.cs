using Core.Entities;
using Core.Services;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService : IServiceRepository<Customer>, IService<Customer>
    {
    }
}
