using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CarWashingAssistant.Configuration;
using CarWashingAssistant.EntityFrameworkCore;
using CarWashingAssistant.Migrator.DependencyInjection;

namespace CarWashingAssistant.Migrator
{
    [DependsOn(typeof(CarWashingAssistantEntityFrameworkModule))]
    public class CarWashingAssistantMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public CarWashingAssistantMigratorModule(CarWashingAssistantEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(CarWashingAssistantMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                CarWashingAssistantConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CarWashingAssistantMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
