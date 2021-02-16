using Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public interface IService<T> : IServiceRepository<T>
        where T : IEntity
    {
    }
}
