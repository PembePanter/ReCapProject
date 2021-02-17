using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
        }

        private static void Test()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                Console.WriteLine("-------------------------------------------------------------");
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Arabanın İsmi : " + car.CarName);
                    Console.WriteLine("Arabanın Rengi : " + car.ColorName);
                    Console.WriteLine("Üretim Yılı : " + car.ModelYear);
                    Console.WriteLine("Günlük Fiyatı : " + car.DailyPrice);
                    Console.WriteLine("Açıklama : " + car.Description);
                    Console.WriteLine("-------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
