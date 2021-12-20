using Core.Utilites.Results;
using Entities.Corcretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
         IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetByBrandId(int brandId);
        IDataResult<List<Car>> GetByColorId(int colorId);
        IDataResult<Car> GetById(int carId);
        IDataResult< List<Car> > GetAll();
       
      IDataResult<List<CarDatailDto>> carDatailDtos();

    }
}
