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
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine("-------------------------------------------------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Arabanın İsmi : " + car.Description);
                Console.WriteLine("Üretim Yılı : " + car.ModelYear);
                Console.WriteLine("Günlük Fiyatı : " + car.DailyPrice);
                Console.WriteLine("-------------------------------------------------------------");
            }
        }
    }
}
