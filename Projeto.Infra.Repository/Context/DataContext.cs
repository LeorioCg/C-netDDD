using Projeto.Domain.Entities;
using Projeto.Infra.Repository.Mapping;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto.Infra.Repository.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["aula"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PlanoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Plano> Planos { get; set; }
    }
}
