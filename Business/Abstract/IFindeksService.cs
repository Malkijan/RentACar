using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFindeksService
    {
        IDataResult<Findeks> Add(Findeks findeks);
        IDataResult<List<Findeks>> GetAll();
        IDataResult<Findeks> GetById(int Id);
        IDataResult<Findeks> GetFindeksByUserId(int userId);
        IDataResult<Findeks> GetFindeksByNatioanlId(string natioanlId);
    }
}
