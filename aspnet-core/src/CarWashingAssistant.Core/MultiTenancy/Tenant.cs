using Abp.MultiTenancy;
using CarWashingAssistant.Authorization.Users;

namespace CarWashingAssistant.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
