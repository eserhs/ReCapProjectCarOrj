using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entities.Corcretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Corcretes.EntityFrameWord
{
  public  class ColorDal:EfEntityRepositoryBase<Color,CarRentalDb>,IColorDal
    {
    }
}
