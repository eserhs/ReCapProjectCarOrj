using Core.IEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Corcretes
{
  public  class Brand:IEntity
    {
        public int BrandID { get; set; }
        public String BrandName { get; set; }


    }
}
