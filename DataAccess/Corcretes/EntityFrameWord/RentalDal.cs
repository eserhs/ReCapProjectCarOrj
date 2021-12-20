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
    public class RentalDal : EfEntityRepositoryBase<Rental, CarRentalDb>, IRentalDal
    {
        public List<RentalDataliDto> rentalDataliDto()
        {
            using (CarRentalDb context = new  CarRentalDb())
            {
                var result = from r in context.RentalTb
                             join c in context.CarTb on r.CarID equals c.CarID
                             join cu in context.CustomerTb on r.CustomerID equals cu.CustomerID
                             join u in context.UserTb on cu.UserID equals u.UserID
                             select new RentalDataliDto
                             {
                                 CarName = c.CarName,
                                 CustomerName = u.UserName + "" + u.UserLastName,
                                 RentalID = r.RentalID,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();





            }
        }
    }
}
