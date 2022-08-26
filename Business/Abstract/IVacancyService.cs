using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IVacancyService
    {
        IDataResult<Vacancy> Get(int id);

        IDataResult<List<Vacancy>> GetList();

        IDataResult<List<Vacancy>> GetListByCategory(int id);

        IResult Add(Vacancy vacancy);

        IResult Delele(Vacancy vacancy);

        IResult Update(Vacancy vacancy); 

    }
}

