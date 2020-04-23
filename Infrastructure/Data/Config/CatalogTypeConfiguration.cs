using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class CatalogTypeConfiguration : IEntityTypeConfiguration<CatalogType>
    {
        public void Configure(EntityTypeBuilder<CatalogType> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .UseHiLo("Catalog_type_hilo")
                .IsRequired();

            builder.Property(c => c.Type)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
