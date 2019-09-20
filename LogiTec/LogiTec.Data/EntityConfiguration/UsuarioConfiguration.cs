using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using LogiTec.Entities;
using LogiTec.Entities.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogiTec.Data.EntityConfiguration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Entities.Usuario.Usuario>
    {

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseSqlServerIdentityColumn();

            builder.HasMany(x => x.DadosComplementares).WithOne(x => x.Usuarios).HasForeignKey(x => x.Usuario_Id).HasPrincipalKey(x => x.Id);

            //    builder.HasMany(x => x.DadosComplementares).WithOne(x => x.Usuarios).HasForeignKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(150)
                .IsRequired();

            builder.HasIndex(x => x.CPF);
            builder.Property(x => x.CPF)
                .HasMaxLength(15)
                .IsRequired();

            builder.HasIndex(x => x.RG);
            builder.Property(x => x.RG)
                .HasMaxLength(15)
                .IsRequired();

            builder.HasIndex(x => x.CNH);
            builder.Property(x => x.CNH)
                .HasMaxLength(15);

            builder.Property(x => x.Nacimento)
               .IsRequired();

            builder.Property(x => x.Telefones)
                .HasMaxLength(200);

            builder.HasIndex(x => x.Email);
            builder.Property(x => x.Email)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Logradouro)
                .HasMaxLength(200);

            builder.Property(x => x.CEP)
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(x => x.Cidade)
               .HasMaxLength(50)
               .IsRequired();


            builder.Property(x => x.Bairro)
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(x => x.Estado)
               .HasMaxLength(2)
               .HasColumnType("Char")
               .IsRequired();

            builder.Property(x => x.RedeSociais)
               .HasMaxLength(200)
               .IsRequired();

            builder.Property(x => x.Login)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.Senha)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
