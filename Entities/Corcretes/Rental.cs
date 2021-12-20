using Core.IEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Corcretes
{
  public  class Rental:IEntity
    {
        public int RentalID { get; set; }
        public int CarID { get; set; }
        public int CustomerID { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
