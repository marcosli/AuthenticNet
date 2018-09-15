using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ML.AuthenticNet.EntityFrameworkCore
{
    public static class AuthenticNetDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AuthenticNetDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AuthenticNetDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
