using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AlvaradoBS.Authorization;

namespace AlvaradoBS
{
    [DependsOn(
        typeof(AlvaradoBSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AlvaradoBSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AlvaradoBSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AlvaradoBSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
