﻿using CSharpEgıtım2.DataAccessLayer.Abstract;
using CSharpEgıtım2.DataAccessLayer.Context;
using CSharpEgıtım2.DataAccessLayer.Repositories;
using CSharpEgıtım2.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgıtım2.DataAccessLayer.EntityFramework
{
    public class EFProductDal : GenericRepesitory<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new CampContext();
            var values = context.Products
                .Select(x => new 
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    ProductStock = x.ProductStock,
                    ProductPrice = x.ProductPrice,
                    ProductDescription = x.ProductDescription,
                    CategoryName = x.Category.CategoryName
                }).ToList();
            return values.Cast<object>().ToList(); 

        }
    }
}
