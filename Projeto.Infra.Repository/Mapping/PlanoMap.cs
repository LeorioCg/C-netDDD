using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto.Infra.Repository.Mapping
{
    public class PlanoMap : EntityTypeConfiguration<Plano>
    {
        public PlanoMap()
        {
            ToTable("Plano");

            HasKey(p => p.IdPlano);

            Property(p => p.IdPlano)
                .HasColumnName("IdPlano");
                

            Property(p => p.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(250)
                .IsRequired();

        }
    }
}
