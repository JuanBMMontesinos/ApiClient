using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositories
{
    public class AppRepository : GenericRepository<Client>, IAppRepository
    {
    }
}
