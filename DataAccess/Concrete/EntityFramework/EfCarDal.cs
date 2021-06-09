using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:EfEntityRepositoryBase<Car,RentACarContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result =
                    from car in context.Cars
                    join brand in context.Brands
                        on car.BrandId equals brand.Id
                    join color in context.Colors
                        on car.ColorId equals color.Id
                    select new CarDetailDto
                    {
                        Id = car.Id,
                        BrandName = brand.Name,
                        ColorName = color.Name,
                        DailyPrice = car.DailyPrice,
                        ModelYear = car.ModelYear,
                        Description = car.Description
                    };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsById(Expression<Func<Car, bool>> filter=null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in filter == null ? context.Cars : context.Cars.Where(filter)
                    join brand in context.Brands on car.BrandId equals brand.Id
                    join color in context.Colors on car.ColorId equals color.Id
                    join carImage in context.CarImages on car.Id equals carImage.CarId
                    select new CarDetailDto
                    {
                        Id = car.Id,
                        BrandName = brand.Name,
                        ColorName = color.Name,
                        DailyPrice = car.DailyPrice,
                        Description = car.Description,
                        ModelYear = car.ModelYear,
                        ImageId = carImage.Id,
                        ImagePath = carImage.ImagePath,
                        Date = carImage.Date

                    };
                return result.ToList();
            }
        }
    }
}
