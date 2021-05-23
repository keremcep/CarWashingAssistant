using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CarWashingAssistant.Authorization;

namespace CarWashingAssistant
{
    [DependsOn(
        typeof(CarWashingAssistantCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CarWashingAssistantApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CarWashingAssistantAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CarWashingAssistantApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
