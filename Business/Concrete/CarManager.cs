using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        private ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [CacheAspect(10)]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetList(),Messages.CarsListed);
        }
        [CacheAspect(10)]
        public IDataResult<Car> GetCarById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(car => car.Id == id),Messages.CarListed);
        }
        [CacheAspect(10)]
        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetList().Where(car => car.BrandId == id).ToList(),Messages.CarsListedByBrand);
        }
        [CacheAspect(10)]
        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetList().Where(car => car.ColorId == id).ToList(),Messages.CarsListedByColor);
        }
        [CacheAspect(10)]
        public IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetList(car =>
                car.DailyPrice >= min && car.DailyPrice <= max),Messages.CarsListedByDailyPrice);
        }
        [CacheAspect(10)]
        public IDataResult<List<Car>> GetCarsByModelYear(int min, int max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetList(car => car.ModelYear >= min && car.ModelYear <= max),Messages.CarsListedByModelYear);
        }
        [CacheAspect(10)]
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarsListed);
        }
        [CacheAspect(10)]
        public IDataResult<List<CarDetailDto>> GetCarDetailsById(Expression<Func<Car, bool>> filter = null)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsById(filter),Messages.CarListed);
        }
        [CacheRemoveAspect("ICarService.Get")]
        [PerformanceAspect(5)]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }
        [CacheRemoveAspect("ICarService.Get")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
    }
}
