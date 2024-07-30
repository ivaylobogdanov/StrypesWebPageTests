using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace StrypesHomePageTests.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;

        public virtual string PageUrl { get; }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public IWebElement AboutLink => driver.FindElement(By.XPath("//section[1]/div/div/div/section[2]/div/div[2]/div/div/div/nav[1]/ul/li[2]/a"));
        public IWebElement SurvicesLink => driver.FindElement(By.XPath("//section[1]/div/div/div/section[2]/div/div[2]/div/div/div/nav[1]/ul/li[3]/a"));

        public IWebElement PageHeading => driver.FindElement(By.CssSelector("h1"));

        public void Open() 
        { 
            driver.Navigate().GoToUrl(this.PageUrl);
        }

        public bool IsPageOpen()
        { 
            return driver.Url == this.PageUrl;
        }

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
