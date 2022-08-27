﻿using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        IDataResult<Company> Get(int id);

        IDataResult<List<Company>> GetList();

        IResult Add(Company company);

        IResult Delele(Company company);

        IResult Update(Company company);
    }
}

