using Business.Abstract;
using Business.Corcretes;
using DataAccess.Corcretes.EntityFrameWord;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ICarService carService = new CarManager(new CarDal ()) ;
           carService.Add(new Entities.Corcretes.Car { CarName = "sende bende", ColorID = 10, BrandID = 10, DailyPrice = 144, Description = "wwsw" });
        
          
        }
    }
}
