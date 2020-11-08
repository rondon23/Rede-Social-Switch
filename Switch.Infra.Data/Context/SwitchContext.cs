using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }


        public SwitchContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Nome)
                        .HasColumnName("Nome")
                        .IsRequired()
                        .HasMaxLength(400);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
