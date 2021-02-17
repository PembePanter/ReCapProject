using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userdal;

        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }

        public IResult Add(User entity)
        {
            _userdal.Add(entity);
            return new SuccessResult(CRUDMessages.UserAdded);
        }

        public IResult Delete(User entity)
        {
            _userdal.Delete(entity);
            return new SuccessResult(CRUDMessages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userdal.GetAll(), CRUDMessages.UsersListed);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userdal.Get(u => u.Id == id),CRUDMessages.UsersListed);
        }

        public IResult Update(User entity)
        {
            _userdal.Update(entity);
            return new SuccessResult(CRUDMessages.UserUpdated);
        }
    }
}
