using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.Results
{
   public class ErrorResult:Result
    {

        public ErrorResult(String message):base(false , message)
        {

        }
        public ErrorResult():base(false)
        {

        }
    }
}
