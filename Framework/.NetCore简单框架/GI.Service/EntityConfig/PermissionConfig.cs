using GI.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Service.EntityConfig
{
    public class PermissionConfig : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.PermissionName);

            // entity.Property(e => e.UserId)
            //    .HasDefaultValueSql("");
            builder.HasQueryFilter(e => e.IsDel == false);

        }
    }
}
