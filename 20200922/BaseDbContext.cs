using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _20200922
{
    public class BaseDbContext : DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");

            modelBuilder.Entity<Detalles>().ToTable("Detalles");

            modelBuilder.Entity<Recursos>().ToTable("Recursos");

            modelBuilder.Entity<Tareas>().ToTable("Tareas");
        }

        /*public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Recursos> Recursos { get; set; }
        public DbSet<Detalles> Detalles { get; set; }*/
        //no me deja usar esto, me dice "Incoherencia de accesibilidad: el tipo de propiedad 'DbSet<Usuarios>' es menos accesible que 'BaseDbContext.Usuarios'
    }
}
