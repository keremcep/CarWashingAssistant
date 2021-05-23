using System.Threading.Tasks;
using CarWashingAssistant.Models.TokenAuth;
using CarWashingAssistant.Web.Controllers;
using Shouldly;
using Xunit;

namespace CarWashingAssistant.Web.Tests.Controllers
{
    public class HomeController_Tests: CarWashingAssistantWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}