using _3dSocial.Domain.Entities;
using System.Collections.Generic;

namespace _3dSocial.Application.Interfaces
{
    public interface IProjectFacade
    {
        void Delete(int _Id);
        Project Get(int Id);
        void Insert(Project obj);
        IList<Project> List();
        void Update(Project obj);
    }
}