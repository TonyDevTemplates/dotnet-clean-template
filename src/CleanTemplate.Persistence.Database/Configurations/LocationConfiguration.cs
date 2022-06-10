﻿using CleanTemplate.Domain.Entities.Locations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanTemplate.Persistence.Database.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.Property(t => t.City)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
