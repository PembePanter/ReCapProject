﻿using Business.Abstract;
using DataAccess;
using DataAccess.Concrete.InMemory;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length < 2)
            {
                Console.WriteLine("Araba ismi en az 2 karakter olmalıdır.");
            }
            else
            {
                if (car.DailyPrice < 1)
                {
                    Console.WriteLine("Arabanın günlük fiyatı 0'dan büyük olmalıdır.");
                }
                else
                {
                    _carDal.Add(car);
                }
            }
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarById(int id)
        {
            return _carDal.GetAll(c=> c.Id == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c=> c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}
