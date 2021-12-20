using Core.IEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Corcretes
{
   public class Car:IEntity
    {
        public int CarID { get; set; }
        public String CarName { get; set; }
        public int BrandID { get; set; }
        public int ColorID { get; set; }
        public DateTime ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public String Description { get; set; }


    }
}
