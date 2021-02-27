using Microsoft.EntityFrameworkCore;
using PersistentDatabase.Config;
using PersistentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersistentDatabase
{
    public class AplicationDatabaseContext : DbContext
    {
        public DbSet<Area> Areas { get; set; }
        public DbSet<Edificio> Edificios { get; set; }
        public DbSet<Piso> Pisos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-7DU9UMH;Database=EmpresaAutos;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new AreaConfiguration(builder.Entity<Area>());
            base.OnModelCreating(builder);
        }
    }
}
