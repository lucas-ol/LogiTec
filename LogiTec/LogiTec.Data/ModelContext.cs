using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogiTec.Data
{
    public class ModelContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(Utils.Config.Instance.ConnectionString);
        }

        public DbSet<LogiTec.Entities.Usuario> Usuarios { get; set; }
    }
}
