using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Asprcts.Autofac.Validatoin;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Corcretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Corcretes
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {

            _rentalDal = rentalDal;
        }
        [ValidationAspect(typeof(RentalValidation))]
        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult("Yeni bir araç kiraladı ");
        }

        public IResult Dalete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
           return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetByRental(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalID == rentalId));
        }

        public IDataResult<List<RentalDataliDto>> RentalDataliDto()
        {
            return new SuccessDataResult<List<RentalDataliDto>>(_rentalDal.rentalDataliDto());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.UpDate(rental);
            return new SuccessResult();
        }
    }
}
