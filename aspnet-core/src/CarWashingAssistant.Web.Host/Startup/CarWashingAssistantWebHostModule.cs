using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CarWashingAssistant.Configuration;

namespace CarWashingAssistant.Web.Host.Startup
{
    [DependsOn(
       typeof(CarWashingAssistantWebCoreModule))]
    public class CarWashingAssistantWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CarWashingAssistantWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CarWashingAssistantWebHostModule).GetAssembly());
        }
    }
}
