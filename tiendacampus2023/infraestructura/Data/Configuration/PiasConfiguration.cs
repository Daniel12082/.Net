using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace infraestructura.Data.Configuration;

        public class PaisConfiguration : IEntityTypeConfiguration<Pais>
        {
            public void Configure(EntityTypeBuilder<Pais> builder)
            {
                builder.ToTable("Pais");
                
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id);

                builder.Property(p => p.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            }
        }
