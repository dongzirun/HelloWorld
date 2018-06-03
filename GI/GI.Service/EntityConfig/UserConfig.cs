using GI.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Service.EntityConfig
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasKey(e => e.UserId);

            entity.HasIndex(e => e.UserName);

            

            // entity.Property(e => e.UserId)
            //    .HasDefaultValueSql("");

            //entity.HasMany(e=>e.Roles)
            //    .WithMany


        }
    }
}
