using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogiTec.Data.Model
{
    public class LogiTectContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Utils.Config.Instance.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
            modelBuilder.ApplyConfiguration(new EntityConfiguration.UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfiguration.DadosComplementaresConfiguration());
                    }

        public DbSet<Entities.Usuario.Usuario> Usuarios { get; set; }
        public DbSet<Entities.Usuario.DadosComplementares> DadosComplementares { get; set; }
    }
}
