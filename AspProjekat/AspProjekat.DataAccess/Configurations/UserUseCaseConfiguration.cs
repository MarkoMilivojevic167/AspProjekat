using AspProjekat.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.EfDataAccess.Configurations
{
    public class UserUseCaseConfiguration : IEntityTypeConfiguration<UserUseCase>
    {
        public void Configure(EntityTypeBuilder<UserUseCase> builder)
        {
            builder.Property(x => x.UserId).IsRequired().HasMaxLength(250);

            builder.Property(x => x.UseCaseId).IsRequired().HasMaxLength(250);
        }
    }
}
