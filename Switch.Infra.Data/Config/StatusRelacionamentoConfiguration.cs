using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    public class StatusRelacionamentoConfiguration : IEntityTypeConfiguration<StatusRelacionamento>
    {
        public void Configure(EntityTypeBuilder<StatusRelacionamento> builder)
        {
            builder.ToTable("statusrelacionamento");

            builder.Property(e => e.Id).HasColumnType("int(11)");

            builder.Property(e => e.Descricao)
                .HasColumnType("longtext");
        }
    }
}
