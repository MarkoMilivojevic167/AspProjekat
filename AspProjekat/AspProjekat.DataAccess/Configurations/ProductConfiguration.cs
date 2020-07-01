using AspProjekat.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.EfDataAccess.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Price).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(50);

            builder.HasMany(pro => pro.Images)
                    .WithOne(x => x.Product)
                    .HasForeignKey(ol => ol.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
