using _3dSocial.Application.Interfaces;
using _3dSocial.Domain.Entities;
using _3dSocial.Service.Services;
using _3dSocial.Service.Validators;

namespace _3dSocial.Application.Facades
{
    public class FileFacade : IFileFacade
    {
        private BaseService<File> service = new BaseService<File>();

        public File Get(int Id)
        {
            return service.Get(Id);
        }

        public void Insert(File obj)
        {
            service.Post<FileValidator>(obj);
        }

        public void Delete(int _Id)
        {
            service.Delete(new File { Id = _Id });
        }
    }
}
