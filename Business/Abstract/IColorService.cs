﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color entity);
        IResult Update(Color entity);
        IResult Delete(Color entity);
        IDataResult<Color> Get(int id);
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetColorById(int Id);
    }
}
