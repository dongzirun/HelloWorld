using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DZT.Authorization.Roles;
using DZT.Authorization.Users;
using DZT.MultiTenancy;

namespace DZT.EntityFrameworkCore
{
    public class DZTDbContext : AbpZeroDbContext<Tenant, Role, User, DZTDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DZTDbContext(DbContextOptions<DZTDbContext> options)
            : base(options)
        {
        }
    }
}
