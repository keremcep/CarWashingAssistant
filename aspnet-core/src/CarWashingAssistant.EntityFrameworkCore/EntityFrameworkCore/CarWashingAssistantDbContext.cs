using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CarWashingAssistant.Authorization.Roles;
using CarWashingAssistant.Authorization.Users;
using CarWashingAssistant.MultiTenancy;

namespace CarWashingAssistant.EntityFrameworkCore
{
    public class CarWashingAssistantDbContext : AbpZeroDbContext<Tenant, Role, User, CarWashingAssistantDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CarWashingAssistantDbContext(DbContextOptions<CarWashingAssistantDbContext> options)
            : base(options)
        {
        }
    }
}
