using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AlvaradoBS.Configuration;

namespace AlvaradoBS.Web.Startup
{
    [DependsOn(typeof(AlvaradoBSWebCoreModule))]
    public class AlvaradoBSWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AlvaradoBSWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<AlvaradoBSNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AlvaradoBSWebMvcModule).GetAssembly());
        }
    }
}
