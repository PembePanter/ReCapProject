using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface ICarDal : IEntityRepository<Car>
    {
    }
}
