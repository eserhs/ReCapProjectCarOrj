using Business.Abstract;
using Core.Utilites.Business;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Corcretes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Corcretes
{
   public class ImageManager:IImageService
    {
        IImageCarDal _ImageDal;

        public ImageManager(IImageCarDal ımageDal)
        {
            _ImageDal = ımageDal;
        }

        public IResult Add(IFormFile file, ImageCar ımageCar)
        {
            var result = BusinessRules.Run(CheckImageRestriction(ımageCar.CarID));
            if (result != null)
            {
                return result;
            }

          ımageCar.ImagePathCar = Core.Utilites.Helper.FileHelper.Add(file);
            ımageCar.Date = DateTime.Now;
            _ImageDal.Add(ımageCar);
            return new SuccessResult("Resim ekledi ");
        }


        public IResult Delete(ImageCar carImage)
        {
            Core.Utilites.Helper.FileHelper.Delete(carImage.ImagePathCar);
            _ImageDal.Delete(carImage);
            return new SuccessResult("resim silindi ");
        }


        public IDataResult<List<ImageCar>> GetAll()
        {
            return new SuccessDataResult<List<ImageCar>>(_ImageDal.GetAll());

        }


        public IDataResult<List<ImageCar>> GetByCarId(int id)
        {
            return new SuccessDataResult<List<ImageCar>>(_ImageDal.GetAll(c => c.CarID == id));
        }



        public IResult Update(IFormFile file, ImageCar carImage)
        {
            carImage.ImagePathCar = Core.Utilites.Helper.FileHelper.Update(_ImageDal.Get(c => c.CarID == carImage.CarID).ImagePathCar, file);
            carImage.Date = DateTime.Now;
            _ImageDal.UpDate(carImage);
            return new SuccessResult("resim güncelledi");
        }


        private IResult CheckImageRestriction(int id)
        {
            var carImageCount = _ImageDal.GetAll(p => p.CarID == id).Count;
            if (carImageCount > 5)
            {
                return new ErrorResult();
            }

            return new SuccessResult();
        }
    }
}

