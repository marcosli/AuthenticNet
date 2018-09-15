using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ML.AuthenticNet.Authorization.Roles;
using ML.AuthenticNet.Authorization.Users;
using ML.AuthenticNet.MultiTenancy;

namespace ML.AuthenticNet.EntityFrameworkCore
{
    public class AuthenticNetDbContext : AbpZeroDbContext<Tenant, Role, User, AuthenticNetDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AuthenticNetDbContext(DbContextOptions<AuthenticNetDbContext> options)
            : base(options)
        {
        }
    }
}
