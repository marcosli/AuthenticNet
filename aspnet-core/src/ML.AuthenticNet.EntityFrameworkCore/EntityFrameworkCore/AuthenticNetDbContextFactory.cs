using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ML.AuthenticNet.Configuration;
using ML.AuthenticNet.Web;

namespace ML.AuthenticNet.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AuthenticNetDbContextFactory : IDesignTimeDbContextFactory<AuthenticNetDbContext>
    {
        public AuthenticNetDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AuthenticNetDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AuthenticNetDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AuthenticNetConsts.ConnectionStringName));

            return new AuthenticNetDbContext(builder.Options);
        }
    }
}
