﻿using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService : IServiceRepository<Car>
    {
        List<Car> GetCarById(int carId);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<CarDetailDto> GetCarDetails();
    }
}
