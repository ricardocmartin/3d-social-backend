using _3dSocial.Domain.Entities;
using System.Collections.Generic;

namespace _3dSocial.Application.Interfaces
{
    public interface ICenterFacade
    {
        void Delete(int _Id);
        Center Get(int Id);
        void Insert(Center obj);
        IList<Center> List();
        void Update(Center obj);
    }
}