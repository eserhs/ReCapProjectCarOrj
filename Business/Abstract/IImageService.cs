using Core.Utilites.Results;
using Entities.Corcretes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IImageService
    {
        IDataResult<List<ImageCar>> GetAll();
        IDataResult<List<ImageCar>> GetByCarId(int id);
        IResult Add(IFormFile file, ImageCar carImage);
        IResult Delete(ImageCar carImage);
        IResult Update(IFormFile file, ImageCar carImage);
    }
}
