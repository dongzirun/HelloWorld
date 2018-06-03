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
        public void Configure(EntityTypeBuilder<Permission> entity)
        {
            entity.HasKey(e => e.Id);

            entity.HasIndex(e => e.PermissionName);

            // entity.Property(e => e.UserId)
            //    .HasDefaultValueSql("");
        }
    }
}
