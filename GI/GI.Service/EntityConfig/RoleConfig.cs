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
        public void Configure(EntityTypeBuilder<Role> entity)
        {
            entity.HasKey(e => e.Id);

            entity.HasIndex(e => e.RoleName);

            // entity.Property(e => e.UserId)
            //    .HasDefaultValueSql("");
        }
    }
}
