using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FindeksManager:IFindeksService
    {
        private IFindeksDal _findeksDal;

        public FindeksManager(IFindeksDal findeksDal)
        {
            _findeksDal = findeksDal;
        }

        public IDataResult<Findeks> Add(Findeks findeks)
        {
            var nationalToCheck = GetFindeksByNatioanlId(findeks.NationalIdentity);
            if (nationalToCheck == null)
            {
                Random value = new Random();
                findeks.FindeksValue = (short)value.Next(0, 1901);
                _findeksDal.Add(findeks);
                return new SuccessDataResult<Findeks>(findeks,Messages.FindeksAdded);
            }

            return new ErrorDataResult<Findeks>(Messages.FindeksAlreadyExists);
        }

        public IDataResult<List<Findeks>> GetAll()
        {
            return new SuccessDataResult<List<Findeks>>(_findeksDal.GetList(),Messages.FindeksListed);
        }

        public IDataResult<Findeks> GetById(int Id)
        {
            return new SuccessDataResult<Findeks>(_findeksDal.Get(c => c.Id == Id));
        }

        public IDataResult<Findeks> GetFindeksByUserId(int userId)
        {
            return new SuccessDataResult<Findeks>(_findeksDal.Get(c => c.UserId == userId));
        }

        public IDataResult<Findeks> GetFindeksByNatioanlId(string natioanlId)
        {
            return new SuccessDataResult<Findeks>(_findeksDal.Get(c => c.NationalIdentity == natioanlId));
        }

    }
}
