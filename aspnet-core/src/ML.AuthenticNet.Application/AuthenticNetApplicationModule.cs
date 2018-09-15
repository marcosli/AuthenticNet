using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ML.AuthenticNet.Authorization;

namespace ML.AuthenticNet
{
    [DependsOn(
        typeof(AuthenticNetCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AuthenticNetApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AuthenticNetAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AuthenticNetApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
