﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgıtım2.EntityLayer.Concrete;

namespace CSharpEgıtım2.BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        void TGetById(Category getByIdValues);
    }
}
