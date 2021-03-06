﻿using Core.Entities;
using Core.Services;
using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService : IServiceRepository<Color>, IService<Color>
    {
    }
}
