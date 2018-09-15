using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ML.AuthenticNet.Configuration;
using ML.AuthenticNet.EntityFrameworkCore;
using ML.AuthenticNet.Migrator.DependencyInjection;

namespace ML.AuthenticNet.Migrator
{
    [DependsOn(typeof(AuthenticNetEntityFrameworkModule))]
    public class AuthenticNetMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AuthenticNetMigratorModule(AuthenticNetEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AuthenticNetMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AuthenticNetConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthenticNetMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
