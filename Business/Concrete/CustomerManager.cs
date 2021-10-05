using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public ICustomerDal _userDal;

        public CustomerManager(ICustomerDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(Customer entity)
        {
            _userDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Customer entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<Customer> Get(int id)
        {
            return new SuccessDataResult<Customer>(_userDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_userDal.GetAll());
        }

        public IResult Update(Customer entity)
        {
            _userDal.Update(entity);
            return new SuccessResult();
        }
    }
}
