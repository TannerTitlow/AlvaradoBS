using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AlvaradoBS.EntityFrameworkCore;
using AlvaradoBS.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AlvaradoBS.Web.Tests
{
    [DependsOn(
        typeof(AlvaradoBSWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AlvaradoBSWebTestModule : AbpModule
    {
        public AlvaradoBSWebTestModule(AlvaradoBSEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AlvaradoBSWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AlvaradoBSWebMvcModule).Assembly);
        }
    }
}