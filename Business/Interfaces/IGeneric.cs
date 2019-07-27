using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IGeneric<T> where T : class
    {
        void Add(T entity);
    }
}
