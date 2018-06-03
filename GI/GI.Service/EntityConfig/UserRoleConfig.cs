using GI.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Service.EntityConfig
{
    public class UserRoleConfig : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(e => e.RoleId);
            builder.HasKey(e => e.UserId);
            builder.HasIndex(e => new
            {
                e.RoleId,
                e.UserId
            });
            builder.HasOne(e => e.Role).WithMany(e => e.UserRoles).HasForeignKey(e => e.RoleId);
            builder.HasOne(e => e.User).WithMany(e => e.UserRoles).HasForeignKey(e => e.UserId);



        }
    }
}
