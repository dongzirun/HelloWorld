using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DZT.Configuration;
using DZT.Web;

namespace DZT.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DZTDbContextFactory : IDesignTimeDbContextFactory<DZTDbContext>
    {
        public DZTDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DZTDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DZTDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DZTConsts.ConnectionStringName));

            return new DZTDbContext(builder.Options);
        }
    }
}
