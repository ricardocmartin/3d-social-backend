using _3dSocial.Domain.Entities;
using _3dSocial.Domain.Interfaces;
using _3dSocial.Infra.Data.Repository;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3dSocial.Service.Services
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        private BaseRepository<T> repository = new BaseRepository<T>();

        public T Post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Insert(obj);
            return obj;
        }

        public T Put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Update(obj);
            return obj;
        }

        public void Delete(T obj)
        {
            if (obj.Id == 0)
                throw new ArgumentException("The id can't be zero.");

            repository.Delete(obj);
        }

        public IList<T> Get() => repository.Select();

        public T Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            return repository.Select(id);
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Record not found!");

            validator.ValidateAndThrow(obj);
        }
    }
}
