using System.Threading.Tasks;
using Microsoft.Playwright;

namespace pages;

public class HomePage : BasePage {
    /**
      * Web Elements
      */
    ILocator menuButton;
    ILocator loginLink;

    /**
      * Constructor
      */
    public HomePage(IPage page) : base(page) {
        menuButton           = Page.Locator("#menu-toggle");
        loginLink            = Page.GetByText("Login");
    }

    /**
      * Page Methods
      */
    //Go to Homepage
    public async Task<HomePage> NavigateToHomepage() {
        //Log.info(String.format("Opening Website: [%s]", configReader.GetAppUrl()));
        await Page.GotoAsync(Config.AppUrl());
        return this;
    }

    //Go to LoginPage
    public async Task<LoginPage> NavigateToLoginPage() {
        //Log.info("Going to Login Page...");

        await ClickAsync(menuButton);
        await ClickAsync(loginLink);

        return new LoginPage(Page);
    }

}