﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoSolo.Core.Entities.User;

namespace NoSolo.Infrastructure.Data.Config.User;

public class UserTagConfiguration : IEntityTypeConfiguration<UserTag>
{
    public void Configure(EntityTypeBuilder<UserTag> builder)
    {
        builder.Property(p => p.Id).IsRequired();
        builder.Property(p => p.Active).IsRequired();
        builder.Property(p => p.Tag).IsRequired().HasMaxLength(20);
    }
}