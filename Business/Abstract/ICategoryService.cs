using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        //IDataResult<Category> Get(int id);

        IDataResult<List<Category>> GetList();

        //IDataResult<List<Category>> GetListByCategory(int id);

        IResult Add(Category vacancy);

        IResult Delele(Category vacancy);

        IResult Update(Category vacancy);
    }
}

