using _3dSocial.Application.DTO;
using _3dSocial.Domain.Entities;
using System.Collections.Generic;

namespace _3dSocial.Application.Interfaces
{
    public interface IDemandFacade
    {
        void Delete(int _Id);
        Demand Get(int Id);
        void Insert(Demand obj);
        void Insert(DemandDTO dto);
        IList<Demand> List();
        void Update(Demand obj);
    }
}