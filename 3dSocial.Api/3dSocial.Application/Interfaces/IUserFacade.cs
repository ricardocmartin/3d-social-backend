using _3dSocial.Domain.Entities;
using System.Collections.Generic;

namespace _3dSocial.Application.Interfaces
{
    public interface IUserFacade
    {
        void Delete(int _Id);
        User Get(int Id);
        void Insert(User obj);
        IList<User> List();
        void Update(User obj);
    }
}