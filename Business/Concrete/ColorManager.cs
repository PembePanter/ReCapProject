using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetColorById(int id)
        {
            return _colorDal.GetAll(c=> c.Id == id);
        }

        public List<Color> GetColorByName(string name)
        {
            return _colorDal.GetAll(c => c.Name == name);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
