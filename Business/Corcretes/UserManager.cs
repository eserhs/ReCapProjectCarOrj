using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Asprcts.Autofac.Validatoin;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Corcretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Corcretes
{
    public class UserManager : IUserService

    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        [ValidationAspect(typeof(UserValidatoin))]
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult("Yeni kişi ekledi");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult("kişi silindi");
        }

        public IDataResult <User> GetById(int Userid)
        {
            return new SuccessDataResult<User>(_userDal.Get(U=>U.UserID==Userid));
        }

        public IDataResult<List<User>> GetALL()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IResult Update(User user)
        {
            _userDal.UpDate(user);
            return new SuccessResult("kişi güncellendi");
        }

       
    }
}
