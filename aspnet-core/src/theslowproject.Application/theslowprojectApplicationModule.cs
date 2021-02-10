using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using theslowproject.Authorization;

namespace theslowproject
{
    [DependsOn(
        typeof(theslowprojectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class theslowprojectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<theslowprojectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(theslowprojectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
