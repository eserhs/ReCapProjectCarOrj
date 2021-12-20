using Core.IEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Corcretes
{
  public  class Color:IEntity
    {
        public int ColorID { get; set; }
        public String ColorName { get; set; }

    }
}
