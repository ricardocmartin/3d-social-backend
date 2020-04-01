using _3dSocial.Application.Interfaces;
using _3dSocial.Domain.Entities;
using _3dSocial.Service.Services;
using _3dSocial.Service.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3dSocial.Application.Facades
{
    public partial class CenterFacade : ICenterFacade
    {
        private BaseService<Center> service = new BaseService<Center>();

        public Center Get(int Id)
        {
            return service.Get(Id);
        }

        public IList<Center> List()
        {
            return service.Get();
        }

        public void Update(Center obj)
        {
            service.Put<CenterValidator>(obj);
        }

        public void Insert(Center obj)
        {
            service.Post<CenterValidator>(obj);
        }
        public void Delete(int _Id)
        {
            service.Delete(new Center { Id = _Id });
        }
    }
}
