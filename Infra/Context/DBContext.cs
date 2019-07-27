using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Infra.Context
{
    public class DBContext : DbContext
    {
        public IConfigurationRoot Configuration { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured) optionBuilder.UseSqlServer(RetornaUrlConection());
        }

        public string RetornaUrlConection()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            string conexao = Configuration.GetConnectionString("DefaultConnection");
            return conexao;
        }
    }
}
