using Core.IEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Corcretes
{
   public class Customer:IEntity
    {

        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public String CompanyName { get; set; }


    }
}
