using LogiTec.Entities.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogiTec.Data.EntityConfiguration
{
    public class DadosComplementaresConfiguration:IEntityTypeConfiguration<DadosComplementares>
    {        
        public void Configure(EntityTypeBuilder<DadosComplementares> builder)
        {
            builder.HasKey(x=> x.Id);
            builder.Property(x => x.Id).UseSqlServerIdentityColumn();

            builder.Property(x=> x.Nome)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Valor)
                .HasMaxLength(200)
                .IsRequired() ;                 

        }
    }
}
