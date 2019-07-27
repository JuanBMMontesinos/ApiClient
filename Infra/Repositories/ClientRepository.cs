using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class ClientRepository : IClientRepository
    {
        Task<Client> IClientRepository.Add(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
