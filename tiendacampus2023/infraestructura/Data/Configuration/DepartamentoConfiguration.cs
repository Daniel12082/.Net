using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infraestructura.Data.Configuration;

    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("Departamento");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasOne(p => p.Pais)
                .WithMany(p => p.Departamentos)
                .HasForeignKey(p => p.IdPaisFk);
        }
    }
