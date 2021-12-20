using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entities.Corcretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Corcretes.EntityFrameWord
{
   public class ImageDal : EfEntityRepositoryBase<ImageCar,CarRentalDb>,IImageCarDal
    {
    }
}
