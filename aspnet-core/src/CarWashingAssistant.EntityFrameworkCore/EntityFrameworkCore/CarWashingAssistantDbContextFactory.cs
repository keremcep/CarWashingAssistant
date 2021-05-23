using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CarWashingAssistant.Configuration;
using CarWashingAssistant.Web;

namespace CarWashingAssistant.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CarWashingAssistantDbContextFactory : IDesignTimeDbContextFactory<CarWashingAssistantDbContext>
    {
        public CarWashingAssistantDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CarWashingAssistantDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CarWashingAssistantDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CarWashingAssistantConsts.ConnectionStringName));

            return new CarWashingAssistantDbContext(builder.Options);
        }
    }
}
