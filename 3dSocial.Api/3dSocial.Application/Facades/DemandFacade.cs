using _3dSocial.Application.Interfaces;
using _3dSocial.Domain.Entities;
using _3dSocial.Service.Services;
using _3dSocial.Service.Validators;
using System.Collections.Generic;

namespace _3dSocial.Application.Facades
{
    public class DemandFacade : IDemandFacade
    {
        private BaseService<Demand> service = new BaseService<Demand>();

        public Demand Get(int Id)
        {
            return service.Get(Id);
        }

        public IList<Demand> List()
        {
            return service.Get();
        }

        public void Update(Demand obj)
        {
            service.Put<DemandValidator>(obj);
        }

        public void Insert(Demand obj)
        {
            service.Post<DemandValidator>(obj);
        }
        public void Delete(int _Id)
        {
            service.Delete(new Demand { Id = _Id });
        }
    }
}
