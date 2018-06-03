using GI.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Service.EntityConfig
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.RoleName);

            // entity.Property(e => e.UserId)
            //    .HasDefaultValueSql("");
            builder.HasQueryFilter(e => e.IsDel == false);

        }
    }
}
