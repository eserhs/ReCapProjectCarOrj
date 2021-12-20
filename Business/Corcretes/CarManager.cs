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
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(CarValidation))]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult("yeni araba ekledi");

        
        }

        public IDataResult<List<CarDatailDto>> carDatailDtos()
        {
            return new SuccessDataResult<List<CarDatailDto>>(_carDal.GetCarDatailDtas(),"arabanın detayına git");
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("kayıtlı araba Silindi");
        }

        public IDataResult<List<Car>> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.BrandID == brandId));
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),"bütün arabalar listeledi ");
        }

        [ValidationAspect(typeof(CarValidation))]
        public IResult Update(Car car)
        {
            _carDal.UpDate(car);
            return new SuccessResult("araba güncelledi");

        }

        public IDataResult<List<Car>> GetByColorId(int colorId)
        {
           return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorID == colorId));
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=> c.CarID==carId));
        }
    }
}
