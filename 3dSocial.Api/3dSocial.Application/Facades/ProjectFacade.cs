using _3dSocial.Application.Interfaces;
using _3dSocial.Domain.Entities;
using _3dSocial.Service.Services;
using _3dSocial.Service.Validators;
using System.Collections.Generic;

namespace _3dSocial.Application.Facades
{
    public class ProjectFacade : IProjectFacade
    {
        private BaseService<Project> service = new BaseService<Project>();

        public Project Get(int Id)
        {
            return service.Get(Id);
        }

        public IList<Project> List()
        {
            return service.Get();
        }

        public void Update(Project obj)
        {
            service.Put<ProjectValidator>(obj);
        }

        public void Insert(Project obj)
        {
            service.Post<ProjectValidator>(obj);
        }
        public void Delete(int _Id)
        {
            service.Delete(new Project { Id = _Id });
        }
    }
}
