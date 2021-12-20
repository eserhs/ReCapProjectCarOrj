using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Asprcts.Autofac.Validatoin;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Corcretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Corcretes
{
    public class CustomerManager : ICustomerService
    {

        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        [ValidationAspect(typeof(CustomerValidation))]
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult("Yeni kişi kayit oldu ");
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult("müşteri silindi ");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),"Müsşteriler listeledi");
        }

        public IDataResult<Customer> GetById(int CustomerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(cu => cu.CustomerID == CustomerId));
        }
        [ValidationAspect(typeof(CustomerValidation))]
        public IResult Update(Customer customer)
        {
            _customerDal.UpDate(customer);
            return new SuccessResult("müşteri güncelledi ");
        }
    }
}
