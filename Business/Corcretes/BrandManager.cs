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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        [ValidationAspect(typeof(BrandValidation))]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
         return new  SuccessResult();
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());

        }

        public IDataResult<Brand> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandID == brandId));
        }
        [ValidationAspect(typeof(BrandValidation))]
        public IResult Update(Brand brand)
        {
            _brandDal.UpDate(brand);
            return new SuccessResult();
        }
    }
}
