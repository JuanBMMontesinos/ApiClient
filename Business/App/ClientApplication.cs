using Business.Interfaces;
using Domain.Interfaces;
using Domain.Models;

namespace Business.App
{
    public class ClientApplication : IApplication
    {
        IAppRepository _appRepository;

        public ClientApplication(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        public void Add(Client entity)
        {
            _appRepository.Add(entity);
        }
    }
}
