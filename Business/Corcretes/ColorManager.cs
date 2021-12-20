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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        [ValidationAspect(typeof(ColorValidatoin))]
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();

        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());

        }

        public IDataResult<Color> GetByColorId(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c=>c.ColorID==colorId));
        }
        [ValidationAspect(typeof(ColorValidatoin))]
        public IResult Update(Color color)
        {
            _colorDal.UpDate(color);
            return new SuccessResult();

        }
    }
}
