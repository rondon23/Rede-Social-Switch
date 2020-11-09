using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

            //builder.ToTable("usuarios");

            //builder.Property(e => e.Id).HasColumnType("int(11)");

            //builder.Property(e => e.Email)
            //    .IsRequired()
            //    .HasColumnType("varchar(400)");

            //builder.Property(e => e.Nome)
            //    .IsRequired()
            //    .HasColumnType("varchar(400)");

            //builder.Property(e => e.Senha)
            //    .IsRequired()
            //    .HasColumnType("varchar(400)");

            //builder.Property(e => e.SobreNome)
            //    .IsRequired()
            //    .HasColumnType("varchar(400)");

            //builder.Property(e => e.UrlFoto)
            //    .IsRequired()
            //    .HasColumnType("varchar(400)");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasMaxLength(400).IsRequired();
            builder.Property(u => u.SobreNome).HasMaxLength(400).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(400).IsRequired();
            builder.Property(u => u.Senha).HasMaxLength(400).IsRequired();
            builder.Property(u => u.Sexo).IsRequired();
            builder.Property(u => u.UrlFoto).HasMaxLength(400).IsRequired();
            builder.Property(u => u.DataNascimento).IsRequired();

            builder.HasOne(u => u.Identificacao)
                .WithOne(i => i.Usuario)
                .HasForeignKey<Identificacao>(i => i.UsuarioId);

            builder.HasMany(u => u.Postagens).WithOne(p => p.Usuario);

        }
    }
}
