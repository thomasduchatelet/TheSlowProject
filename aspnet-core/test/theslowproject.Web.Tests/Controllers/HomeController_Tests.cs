using System.Threading.Tasks;
using theslowproject.Models.TokenAuth;
using theslowproject.Web.Controllers;
using Shouldly;
using Xunit;

namespace theslowproject.Web.Tests.Controllers
{
    public class HomeController_Tests: theslowprojectWebTestBase
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