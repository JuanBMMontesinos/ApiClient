using Domain.Interfaces;
using Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DbContextOptionsBuilder<DBContext> _optionsBuilder;
        
        public GenericRepository()
        {
            _optionsBuilder = new DbContextOptionsBuilder<DBContext>();
        }

        public void Add(T entity)
        {
            using (var database = new DBContext(_optionsBuilder.Options))
            {
                database.Add(entity);
                database.SaveChanges();
            };
        }
    }
}
