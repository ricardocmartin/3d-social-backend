using _3dSocial.Domain.Entities;

namespace _3dSocial.Application.Interfaces
{
    public interface IFileFacade
    {
        void Delete(int _Id);
        File Get(int Id);
        void Insert(File obj);
    }
}