using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using theslowproject.EntityFrameworkCore;
using theslowproject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace theslowproject.Web.Tests
{
    [DependsOn(
        typeof(theslowprojectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class theslowprojectWebTestModule : AbpModule
    {
        public theslowprojectWebTestModule(theslowprojectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(theslowprojectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(theslowprojectWebMvcModule).Assembly);
        }
    }
}