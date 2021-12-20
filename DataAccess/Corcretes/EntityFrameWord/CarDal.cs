using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entities.Corcretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Corcretes.EntityFrameWord
{
    public class CarDal : EfEntityRepositoryBase<Car, CarRentalDb>, ICarDal
    {
        public List<CarDatailDto> GetCarDatailDtas()
        {
            using (CarRentalDb context= new CarRentalDb() )
            {
                var result = from c in context.CarTb
                             join b in context.BrandTb
                             on c.BrandID equals b.BrandID
                             join co in context.ColorTb
                             on c.ColorID equals co.ColorID
                             select new CarDatailDto
                             {
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();

            }
            
        }
    }
}
