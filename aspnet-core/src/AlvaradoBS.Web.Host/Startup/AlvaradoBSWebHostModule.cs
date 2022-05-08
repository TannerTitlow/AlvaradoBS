using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AlvaradoBS.Configuration;

namespace AlvaradoBS.Web.Host.Startup
{
    [DependsOn(
       typeof(AlvaradoBSWebCoreModule))]
    public class AlvaradoBSWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AlvaradoBSWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AlvaradoBSWebHostModule).GetAssembly());
        }
    }
}
