using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Marka | " + car.BrandName + "         " + "İsim | " + car.CarName + "         " + "Renk | " + car.ColorName + "         " + "Günlük Fiyat | " + car.DailyPrice);
            }
            Console.ResetColor();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

        }

        //private static void Test()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    Console.WriteLine("-------------------------------------------------------------");
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine("Arabanın İsmi : " + car.Description);
        //        Console.WriteLine("Üretim Yılı : " + car.ModelYear);
        //        Console.WriteLine("Günlük Fiyatı : " + car.DailyPrice);
        //        Console.WriteLine("-------------------------------------------------------------");
        //    }
        //}
    }
}
