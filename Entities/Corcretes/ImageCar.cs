using Core.IEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Corcretes
{
  public  class ImageCar:IEntity
    {
        [Key]
        public int ImageID { get; set; }
        public int CarID { get; set; }
        public DateTime Date { get; set; }
        public string ImagePathCar { get; set; }

    } 
}
