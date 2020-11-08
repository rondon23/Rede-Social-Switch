﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

            builder.ToTable("usuarios");

            builder.Property(e => e.Id).HasColumnType("int(11)");

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnType("varchar(400)")
                .HasDefaultValueSql("''")
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_0900_ai_ci");

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnType("varchar(400)")
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_0900_ai_ci");

            builder.Property(e => e.Senha)
                .IsRequired()
                .HasColumnType("varchar(400)")
                .HasDefaultValueSql("''")
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_0900_ai_ci");

            builder.Property(e => e.SobreNome)
                .IsRequired()
                .HasColumnType("varchar(400)")
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_0900_ai_ci");

            builder.Property(e => e.UrlFoto)
                .IsRequired()
                .HasColumnType("varchar(400)")
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_0900_ai_ci");
        }
    }
}