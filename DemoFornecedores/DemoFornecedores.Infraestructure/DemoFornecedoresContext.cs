using DemoFornecedores.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFornecedores.Infraestructure
{
    public class DemoFornecedoresContext : DbContext
    {
        public DemoFornecedoresContext() { }

        public DemoFornecedoresContext(DbContextOptions option) : base(option) { }

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Setor> Setores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DemoFornecedores;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>().ToTable("Fornecedor").HasKey(f => new { f.Id });
            modelBuilder.Entity<Setor>().ToTable("Setor").HasKey(s => new { s.Id });
        }
    }
}