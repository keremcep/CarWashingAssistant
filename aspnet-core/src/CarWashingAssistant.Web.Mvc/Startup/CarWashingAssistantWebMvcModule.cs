using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CarWashingAssistant.Configuration;

namespace CarWashingAssistant.Web.Startup
{
    [DependsOn(typeof(CarWashingAssistantWebCoreModule))]
    public class CarWashingAssistantWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CarWashingAssistantWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<CarWashingAssistantNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CarWashingAssistantWebMvcModule).GetAssembly());
        }
    }
}
