using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DZT.EntityFrameworkCore
{
    public static class DZTDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DZTDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DZTDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
