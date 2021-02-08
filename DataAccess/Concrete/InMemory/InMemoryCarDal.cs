using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        public int _length;
        List<Car> _cars;

        public InMemoryCarDal()
        {

            _cars = new List<Car> {
                new Car {CarId = 1 , BrandId = 1 , ColorId = 1 , ModelYear = 2018 , DailyPrice = 200 , Description = "Orjinal boya 40.000 KM."},
                new Car {CarId = 2 , BrandId = 3 , ColorId = 3 , ModelYear = 2020 , DailyPrice = 300 , Description = "1.000 Km Tertemiz."},
                new Car {CarId = 3 , BrandId = 2 , ColorId = 2 , ModelYear = 2015 , DailyPrice = 130 , Description = "Sağ arka kapısı değişmiştir. Harici temiz."},
                new Car {CarId = 4 , BrandId = 4 , ColorId = 1 , ModelYear = 2016 , DailyPrice = 160 , Description = "İçinde sigara içilmemiş temiz araba."},
                new Car {CarId = 5 , BrandId = 1 , ColorId = 4 , ModelYear = 2018 , DailyPrice = 200 , Description = "Boyası değişmiştir."}
            };
            _length = _cars.Count;
        }
        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Ekleme işlemi başarılı.");
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(c => c.CarId == car.CarId));
            Console.WriteLine("Silme işlemi başarılı.");
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public void Update(Car car)
        {

            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
        public int Length()
        {
            return (_cars.Count);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
