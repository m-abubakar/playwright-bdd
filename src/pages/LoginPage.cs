using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace pages
{
    public class LoginPage : BasePage {
        /**
         * Web Elements
         */
        ILocator menuButton;
        ILocator usernameInput;
        ILocator passwordInput;
        ILocator loginButton;
        ILocator loginLink;
        ILocator profileLink;
        ILocator logoutLink;
        ILocator loginMessage;


        /**
         * Constructor
         */
        public LoginPage(IPage page) : base(page) {
            menuButton                = page.Locator("#menu-toggle");
            usernameInput             = page.Locator("#txt-username");
            passwordInput             = page.Locator("#txt-password");
            loginButton               = page.Locator("#btn-login");
            loginLink                 = page.GetByText("Login");
            profileLink               = page.GetByText("Profile");
            logoutLink                = page.GetByText("Logout");
            loginMessage              = page.Locator("//p[text()='Please login to make appointment.']");
        }

        /**
         * Page Methods
         */
         public async Task<LoginPage> PerformLogin(String username, String password) {
            //Log.info("Trying to login");
            await WriteText(usernameInput, username);
            await WriteText(passwordInput, password);
            await ClickAsync(loginButton);
            return this;
        }

        //Verify Login Condition
        public LoginPage VerifyLoginError(String expectedText) {
            //Log.info("Verifying login username.");
            //IWebElement alertMessage = LocateBelow(loginMessage, By.XPath("//p[@class='lead text-danger']"));
            //Assert.Equal(expectedText, alertMessage.Text);
            return this;
        }

        //Verify Password Condition
        public LoginPage VerifyLogError(String error) {
            //Log.info("Verifying javascript login errors.");
            //Assert.True(BrowserConsoleLogPresent(error));
            return this;
        }

        //Verify if reached Profile page
        public LoginPage VerifyProfilePage() {
            //Log.info("Verifying profile page.");
            //Click(menuButton);
            //Assert.Equal(ReadText(profileLink), profileLink.ToString().Replace("By.linkText: ", ""));
            //Click(menuButton);
            return this;
        }

        // Logout
        public async Task<LoginPage> PerformLogout() {
            //Log.info("Verifying logout.");
            await ClickAsync(menuButton);
            await ClickAsync(logoutLink);
            await ClickAsync(menuButton);
            await Expect(loginLink).ToHaveTextAsync("");
            //Assert.Equal(ReadText(loginLink), loginLink.ToString().Replace("By.linkText: ", ""));
            return this;
        }
    }
}