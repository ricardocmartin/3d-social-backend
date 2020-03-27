using _3dSocial.Application.Interfaces;
using _3dSocial.Domain.Entities;
using _3dSocial.Service.Services;
using _3dSocial.Service.Validators;
using System.Collections.Generic;

namespace _3dSocial.Application.Facades
{
    public class UserFacade : IUserFacade
    {
        private BaseService<User> service = new BaseService<User>();

        public User Get(int Id)
        {
            return service.Get(Id);
        }

        public IList<User> List()
        {
            return service.Get();
        }

        public void Update(User obj)
        {
            service.Put<UserValidator>(obj);
        }

        public void Insert(User obj)
        {
            service.Post<UserValidator>(obj);
        }
        public void Delete(int _Id)
        {
            service.Delete(new User { Id = _Id });
        }
    }
}
