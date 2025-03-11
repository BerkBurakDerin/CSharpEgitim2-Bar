﻿using CSharpEgıtım2.BusinessLayer.Abstract;
using CSharpEgıtım2.DataAccessLayer.Abstract;
using CSharpEgıtım2.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgıtım2.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }
        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }
        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Object> TGetProductsWithCategory()
        {
            return _productDal.GetProductsWithCategory();
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }
        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
