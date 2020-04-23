using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class CatalogBrandConfiguration : IEntityTypeConfiguration<CatalogBrand>
    {
        public void Configure(EntityTypeBuilder<CatalogBrand> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .UseHiLo("Catalog_brand_hilo")
                .IsRequired();

            builder.Property(c => c.Brand)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
