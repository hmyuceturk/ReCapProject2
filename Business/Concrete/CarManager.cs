using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;
        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }
        
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car entity)
        {
            //ValidationTool.Validate(new CarValidator(),entity);
            //if (Validate(entity))
            //{
                _iCarDal.Add(entity);
                return new SuccessResult();
            //}
            //else
            //{
            //    return new ErrorResult(Business.Constants.Messages.NotAdded);
            //}
        }
        public IResult Delete(Car entity)
        {
            if (Validate(entity))
            {
                _iCarDal.Add(entity);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult(Business.Constants.Messages.NotAdded);
            }
        }
        public IResult Update(Car entity)
        {
            if (Validate(entity))
            {
                _iCarDal.Add(entity);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult(Business.Constants.Messages.NotAdded);
            }
        }
        public IDataResult<List<Car>> GetAll()
        {

            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll());      
        }
        public IDataResult<Car> Get(int id)
        {
            return new SuccessDataResult<Car>(_iCarDal.Get(x=>x.Id==id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_iCarDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>> (_iCarDal.GetAll(c=>c.BrandId==brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>( _iCarDal.GetAll(c => c.ColorId == colorId));
        }

        public bool Validate(Car car)
        {
            bool deger = true;
            if (car.Description.Length < 2) 
            { return false; }
            else if (car.DailyPrice <=0)
            { return false; }
            return true;
        }

        
    }
}
