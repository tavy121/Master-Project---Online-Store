﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BookStore.DataAccess.Interfaces
{
    public interface IRepository <T,G>where T:class, Models.IEntity<G> where G:IEquatable<G>
    {
        IEnumerable<T> GetAll();
        T GetInstance(G id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool IsUnique(Expression<Func<T, bool>> predicate);
    }
}
