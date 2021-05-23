using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CarWashingAssistant.EntityFrameworkCore
{
    public static class CarWashingAssistantDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CarWashingAssistantDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CarWashingAssistantDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
