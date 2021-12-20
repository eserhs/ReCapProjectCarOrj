using Core.Utilites.Results;
using Entities.Corcretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<User>> GetALL();
        IDataResult<User> GetById(int Userid);
        
    }
}
