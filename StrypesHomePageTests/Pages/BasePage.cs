using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace StrypesHomePageTests.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        WebDriverWait Wait;
        protected static string BaseUrl = "https://ict-strypes.eu";

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public IWebElement AcceptAllCookiesButton => driver.FindElement(By.XPath("//button[@class='cky-btn cky-btn-accept' and text()='Accept All']"));
        
        public IWebElement PageHeading => driver.FindElement(By.CssSelector("h1"));

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public string GetPageHeadingText()
        {
            return PageHeading.Text;
        }
    }
}
