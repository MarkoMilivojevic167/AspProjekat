using AspProjekat.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.EfDataAccess.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.Property(x => x.Path).IsRequired().HasMaxLength(250); 

            builder.Property(x => x.Alt).HasMaxLength(250);
        }
    }
}
