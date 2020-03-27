using _3dSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3dSocial.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Remove<T>(int id);

        T Select(int id);

        IList<T> SelectAll();
    }
}
