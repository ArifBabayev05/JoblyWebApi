using System;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //public IDataResult<Category> Get(int id)
        //{
        //    return new SuccessDataResult<Category>(_categoryDal.Get(p => p.Id == id));
        //}

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }

        //public IDataResult<List<Category>> GetListByCategory(int id)
        //{
        //    return new SuccessDataResult<List<Category>>(_categoryDal.GetList(p => p.Id == id).ToList());
        //}

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delele(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.Deleted);

        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.Updated);

        }
    }
}

