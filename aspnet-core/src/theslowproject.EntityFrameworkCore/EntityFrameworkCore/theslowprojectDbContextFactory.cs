using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using theslowproject.Configuration;
using theslowproject.Web;

namespace theslowproject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class theslowprojectDbContextFactory : IDesignTimeDbContextFactory<theslowprojectDbContext>
    {
        public theslowprojectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<theslowprojectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            theslowprojectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(theslowprojectConsts.ConnectionStringName));

            return new theslowprojectDbContext(builder.Options);
        }
    }
}
