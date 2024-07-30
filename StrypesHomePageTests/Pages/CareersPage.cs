using OpenQA.Selenium;

namespace StrypesHomePageTests.Pages
{
    public class CareersPage : BasePage
    {
        public CareersPage(IWebDriver driver) : base(driver)
        { 
        }

        public override string PageUrl => "https://strypes.eu/careers/";

        public IWebElement ElementHeadingTitle => driver.FindElement(By.CssSelector("h2 > span"));

        public IWebElement ViewButton => driver.FindElement(By.XPath("//section[6]/div/div/div/div/div/div/article[1]/div/section/div/div[2]/div/div/div/div/a"));
    }
}
