using _3dSocial.Domain.Entities;
using System.Collections.Generic;

namespace _3dSocial.Application.Interfaces
{
    public interface IDemandFacade
    {
        void Delete(int _Id);
        Demand Get(int Id);
        void Insert(Demand obj);
        IList<Demand> List();
        void Update(Demand obj);
    }
}