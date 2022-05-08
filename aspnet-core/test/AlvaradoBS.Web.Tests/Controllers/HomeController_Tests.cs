using System.Threading.Tasks;
using AlvaradoBS.Models.TokenAuth;
using AlvaradoBS.Web.Controllers;
using Shouldly;
using Xunit;

namespace AlvaradoBS.Web.Tests.Controllers
{
    public class HomeController_Tests: AlvaradoBSWebTestBase
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