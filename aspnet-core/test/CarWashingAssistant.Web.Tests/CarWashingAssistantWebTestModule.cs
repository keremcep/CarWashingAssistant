using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CarWashingAssistant.EntityFrameworkCore;
using CarWashingAssistant.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace CarWashingAssistant.Web.Tests
{
    [DependsOn(
        typeof(CarWashingAssistantWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CarWashingAssistantWebTestModule : AbpModule
    {
        public CarWashingAssistantWebTestModule(CarWashingAssistantEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CarWashingAssistantWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CarWashingAssistantWebMvcModule).Assembly);
        }
    }
}