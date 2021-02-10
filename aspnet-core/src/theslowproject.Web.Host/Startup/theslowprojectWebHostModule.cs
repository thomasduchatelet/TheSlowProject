using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using theslowproject.Configuration;

namespace theslowproject.Web.Host.Startup
{
    [DependsOn(
       typeof(theslowprojectWebCoreModule))]
    public class theslowprojectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public theslowprojectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(theslowprojectWebHostModule).GetAssembly());
        }
    }
}
