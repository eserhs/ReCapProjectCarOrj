using Core.Utilites.Results;
using Entities.Corcretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Dalete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetByRental(int rentalId);
        IDataResult<List<RentalDataliDto>> RentalDataliDto(); 


    }
}
