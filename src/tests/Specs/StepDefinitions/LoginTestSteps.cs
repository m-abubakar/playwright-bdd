using System.Threading.Tasks;
using pages;
using Reqnroll;

namespace Specs.StepDeinitions;

[Binding]
public class PriceCalculationStepDefinitions : BaseTest
{
    [Given("the home page is open")]
    public async Task GivenTheClientStartedShopping()
    {
        await homePage.NavigateToHomepage();
    }

    [Given("the user navigates to the login page")]
    public async Task navigateToLoginPage()
    {
        loginPage = await homePage.NavigateToLoginPage();
    }

    //[Given("the user enters the username {int} pcs of {string} to the basket")]
    [Given("the user enters the username {string} and password {string} into the fields")]
    public async Task enterUserName(string username, string password)
    {
       await loginPage.PerformLogin(username, password); 
    }


    [Then("the user is logged in")]
    public async Task verifyUserLogin(decimal expectedPrice)
    {
        await loginPage.VerifyLogError("");
    }

    LoginPage loginPage;
}