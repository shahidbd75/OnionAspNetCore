﻿using Onion.Entity.Base;
using System.Linq;

namespace Onion.DAL.Interfaces.Base
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        T Get(long id);
        IQueryable<T> GetQueryable(long id);
        IQueryable<T> GetQueryable();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
