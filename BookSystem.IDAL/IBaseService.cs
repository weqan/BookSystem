using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem.IDAL
{
    public interface IBaseService<T>:IDisposable where T:Models.BaseEntity
    {
        void Add(T t);
        void Edit(T t);
        void Remove(Guid id);
        T GetOne(Guid id);
        IQueryable<T> GetAll();
    }
}
