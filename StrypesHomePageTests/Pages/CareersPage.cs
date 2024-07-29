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

        public string GetHeadingTitle()
        {
            string headingTitleText = this.ElementHeadingTitle.Text;
            return headingTitleText;
        }

        //IWebElement ElementHeadingQA => driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div/main/div/section[4]/div/div/div/div/div/h2"));

    }
}
