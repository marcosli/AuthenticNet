using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ML.AuthenticNet.Configuration;

namespace ML.AuthenticNet.Web.Host.Startup
{
    [DependsOn(
       typeof(AuthenticNetWebCoreModule))]
    public class AuthenticNetWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AuthenticNetWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthenticNetWebHostModule).GetAssembly());
        }
    }
}
