using Core.IEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Corcretes
{
  public  class User:IEntity
    {
        public int UserID { get; set; }
        public String UserName { get; set; }
        public String UserLastName { get; set; }
        public String  Email { get; set; }
        public String Password { get; set; }

    }
}
