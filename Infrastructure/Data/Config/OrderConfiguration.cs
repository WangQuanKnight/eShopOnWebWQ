using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Data.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            IMutableNavigation navigation = builder.Metadata.FindNavigation(nameof(Order.OrderItems));
            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.OwnsOne(o => o.ShipToAddress, a =>
             {
                 a.WithOwner();

                 a.Property(a => a.ZipCode)
                    .HasMaxLength(18)
                    .IsRequired();

                 a.Property(a => a.Street)
                    .HasMaxLength(180)
                    .IsRequired();

                 a.Property(a => a.State)
                    .HasMaxLength(60);

                 a.Property(a => a.Country)
                    .HasMaxLength(90)
                    .IsRequired();

                 a.Property(a => a.City)
                    .HasMaxLength(180)
                    .IsRequired();
             });
        }
    }
}
