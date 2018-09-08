using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infra.Repository.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");

            HasKey(c => c.IdCliente);

            Property(c => c.IdCliente)
                .HasColumnName("IdCliente");

            Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Email)
                .HasColumnName("Email")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.DataNascimento)
                .HasColumnName("DataNascimento")
                .IsRequired();

            Property(c => c.IdPlano)
                .HasColumnName("IdPlano")                
                .IsRequired();

            HasRequired(c => c.Plano)
                .WithMany(p => p.Clientes)
                .HasForeignKey(c => c.IdPlano);
        }
    }
}
