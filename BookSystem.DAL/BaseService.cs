using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem.DAL
{
    public class BaseService<T> : IDAL.IBaseService<T> where T:Models.BaseEntity,new()
    {
        private Models.BookSystemContext db = new Models.BookSystemContext();
        public void Add(T t)
        {
            db.Set<T>().Add(t);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Edit(T t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return db.Set<T>().Where(m => !m.IsRemoved).AsNoTracking();
        }

        public T GetOne(Guid id)
        {
            return GetAll().First(m => m.Id == id);
        }

        public void Remove(Guid id)
        {
            var t = new T() { Id = id };
            db.Entry(t).State = EntityState.Unchanged;
            t.IsRemoved = true;
            db.SaveChanges();
        }
    }
}
