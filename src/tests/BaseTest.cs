using System.Globalization;
using Microsoft.Playwright;
using pages;
using Utils;


public class BaseTest : IAsyncLifetime
{
    public async Task InitializeAsync()
    {
        Console.WriteLine("Tests are starting!");

        // Perform any setup before tests run
        string config_browser = new ConfigReader().Browser().ToLower(CultureInfo.InvariantCulture);

        playwright = await Playwright.CreateAsync();

        if (config_browser == "firefox")
        {
            // Setup Firefox driver
            //var firefox = playwright.Firefox;
            //driver = new FirefoxDriver();
        }
        else if (config_browser == "chrome")
        {
            // Setup Chrome driver
            var chrome = playwright.Chromium;

            // initialize a Chromium instance
            browser = await chrome.LaunchAsync(new()
            {
                Headless = true, // set to "false" while developing
            });
        }
        else if (config_browser == "edge")
        {
            // Setup Edge driver
            //driver = new EdgeDriver();
        }
        else if (config_browser == "ie")
        {
            // Setup Internet Explorer driver
            //driver = new InternetExplorerDriver();
        }
        else
        {
            throw new Exception("Browser unsupported");
        }

        page = await browser.NewPageAsync();
        homePage = new HomePage(page);
        await Task.CompletedTask;
    }

    public async Task DisposeAsync()
    {
        Console.WriteLine("Tests are ending!");
        //browser
        await Task.CompletedTask;
    }


    IPlaywright playwright;
    IBrowser browser;
    IPage page;
    protected HomePage homePage;
}