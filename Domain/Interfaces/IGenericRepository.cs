using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
    }
}
