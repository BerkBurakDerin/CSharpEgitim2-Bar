using CSharpEgıtım2.DataAccessLayer.Abstract;
using CSharpEgıtım2.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgıtım2.DataAccessLayer.Repositories
{
    public class GenericRepesitory<T> : IGenericDal<T> where T : class
    {
        CampContext context = new CampContext();
        DbSet<T> _object;
        public GenericRepesitory()
        {
            _object = context.Set<T>();
        }
        public void Delete(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
        public List<T> GetAll()
        {
            return _object.ToList();
        }
        public T GetById(int id)
        {
            return _object.Find(id);
        }
        public void Insert(T entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            var uptadedEntity = context.Entry(entity);
            uptadedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
