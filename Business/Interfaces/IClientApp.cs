using Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IClientApp
    {
        Task<Client> Add(Client entity);
    }
}
