using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;
using Utils;

namespace pages
{
    public class BasePage : PageTest {
        public BasePage(IPage page) {
            Page = page;
            Config = new ConfigReader();
        }

        //public IWebElement ScrollTo(By by) {
        //    IWebElement element = WaitVisibility(by);

        //    Actions actions = new Actions(Driver);
        //    actions.MoveToElement(element).Perform();
        //    Thread.Sleep(1000);
        //    actions.MoveToElement(element).Perform();

        //    return element;
        //}

        public async Task<ILocator> ClickAsync(ILocator locator) {
            await locator.ClickAsync();
            return locator;
        }

        //public IWebElement ClickByAction(By by) {
        //    IWebElement element = ScrollTo(by);
        //    Actions actions = new Actions(Driver);
        //    actions.MoveByOffset(5, 5).Click().Perform();
        //    return element;
        //}

        //public IWebElement Clear(By by) {
        //    IWebElement element = WaitVisibility(by);
        //    element.Clear();    
        //    return element;
        //}

        public async Task<ILocator> WriteText(ILocator locator, String text) {
            await locator.FillAsync(text);
            return locator;
        }

        public Task<ILocator> WriteTextWithClear(ILocator locator, String text) {
            locator.ClearAsync().ContinueWith(locator -> FillAsync(text));
            return locator;
        }

        public async Task<String> ReadText(ILocator locator) {
            return await locator.;
        }

        //public bool IsChecked(By by) {
        //    IWebElement element = WaitVisibility(by);
        //    return element.Selected;
        //}

        //public IWebElement SelectOptionByVisible(By by, String option) {
        //    IWebElement element = WaitVisibility(by);
        //    SelectElement select = new SelectElement(element);
        //    select.SelectByText(option);
        //    return element;
        //}

        //public IWebElement SelectOptionByIndex(By by, int index) {
        //    IWebElement element = WaitVisibility(by);
        //    SelectElement select = new SelectElement(element);
        //    select.SelectByIndex(index);
        //    return element;
        //}

        //public String SelectedOptionReadText(By by, int index) {
        //    IWebElement element = WaitVisibility(by);
        //    SelectElement select = new SelectElement(element);
        //    return select.SelectedOption.Text;
        //}

        //public String CurrentUrl() {
        //    return Driver.Url;
        //}

        //public void NavigateTo(String url) {
        //    Driver.Navigate().GoToUrl(url);
        //}

        //public void MaximizeWindow() {
        //    Driver.Manage().Window.Maximize();
        //}

        //public void SwitchToTab(String title) {
        //    foreach (var handle in Driver.WindowHandles) {
        //        if (handle.Contains(title)) {
        //            Driver.SwitchTo().Window(handle);
        //            break;
        //        } 
        //    }
        //}

        //public void Quit() {
        //    Driver.Close();
        //    Driver.Quit();
        //}

        //public String AlertReadText() {
        //    wait_.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
        //    return Driver.SwitchTo().Alert().Text;
        //}

        //public void AlertAccept() {
        //    wait_.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
        //    Driver.SwitchTo().Alert().Accept();
        //}

        //public void AlertDismiss() {
        //    wait_.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
        //    Driver.SwitchTo().Alert().Dismiss();
        //}

        //public void HighlightElement(IWebElement element)
        //{
        //    string highlightScript = @"
        //        arguments[0].style.border='3px solid red';
        //        arguments[0].style.backgroundColor='yellow';
        //    ";
        //    ((IJavaScriptExecutor)Driver).ExecuteScript(highlightScript, element);
        //}

        //public void HighlightElementClear(IWebElement element)
        //{
        //    string highlightScript = @"
        //        arguments[0].style.border='';
        //        arguments[0].style.backgroundColor='';
        //    ";
        //    ((IJavaScriptExecutor)Driver).ExecuteScript(highlightScript, element);
        //}

        //public IWebElement ClickScript(By by) {
        //    IWebElement element = WaitVisibility(by);
        //    ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView();", element);
        //    ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", element);
        //    return element;

        //}

        //public IWebElement LocateBelow(By by, By anchor) {
        //    return Driver.FindElement(RelativeBy.WithLocator(by).Below(anchor));    
        //}

        //public IWebElement LocateAbove(By by, By anchor) {
        //    return Driver.FindElement(RelativeBy.WithLocator(by).Above(anchor));    
        //}

        //public IWebElement LocateLeftOf(By by, By anchor) {
        //    return Driver.FindElement(RelativeBy.WithLocator(by).LeftOf(anchor));    
        //}

        //public IWebElement LocateRightOf(By by, By anchor) {
        //    return Driver.FindElement(RelativeBy.WithLocator(by).RightOf(anchor));    
        //}
        
        //public IWebElement LocateNear(By by, By anchor) {
        //    return Driver.FindElement(RelativeBy.WithLocator(by).Near(anchor));    
        //}

        //public IReadOnlyCollection<LogEntry> BrowserConsoleLogs() {
        //    return Driver.Manage().Logs.GetLog(LogType.Browser);
        //}

        //public Boolean BrowserConsoleLogPresent(String message) {
        //    return BrowserConsoleLogs().Any(log => log.Message.Contains(message));
        //}



        public ConfigReader Config { get; set; }
        public IPage Page { get; set; }

    } 

}