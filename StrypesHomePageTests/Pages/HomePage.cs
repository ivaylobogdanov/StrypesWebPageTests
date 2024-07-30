

using OpenQA.Selenium;

namespace StrypesHomePageTests.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://strypes.eu/";

        public IWebElement ElementHeadingTitle => driver.FindElement(By.CssSelector("h1"));
        public IWebElement ElementAboutLink => driver.FindElement(By.XPath("//section[2]/div/div[2]/div/div/div/nav[1]/ul/li[2]/a"));
    }
}
