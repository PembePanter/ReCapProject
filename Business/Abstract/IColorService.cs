using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService : IServiceRepository<Color>
    {
        List<Color> GetColorById(int colorId);
    }
}
