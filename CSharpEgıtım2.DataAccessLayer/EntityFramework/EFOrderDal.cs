using CSharpEgıtım2.DataAccessLayer.Abstract;
using CSharpEgıtım2.DataAccessLayer.Repositories;
using CSharpEgıtım2.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgıtım2.DataAccessLayer.EntityFramework
{
    public class EFOrderDal: GenericRepesitory<Order> , IOrderDal
    {
    }
}
