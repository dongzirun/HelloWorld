using GI.Service.EntityConfig;
using GI.Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GI.Service
{
    public class GIContext : DbContext
    {
        public GIContext(DbContextOptions<GIContext> options) : base(options)
        {

        }

        public DbSet<Role> Role { get; set; }

        public DbSet<User> User { get; set; }
        public DbSet<Permission> Permission { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
