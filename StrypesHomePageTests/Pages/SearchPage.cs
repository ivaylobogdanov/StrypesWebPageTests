using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace StrypesHomePageTests.Pages
{
    public class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        WebDriverWait Wait;

        public readonly string Url = BaseUrl;

        //public IWebElement ElementSearch => driver.FindElement(By.XPath("//div[@class='elementor-search-form__toggle']/i[@class='fas fa-search']"));
        public IWebElement ElementSearchLens => driver.FindElement(By.XPath("//div/i[@class='fas fa-search']"));
        public IWebElement ElementSearchInput => driver.FindElement(By.XPath("//input[@id='elementor-search-form-5295a54a']"));

        public ReadOnlyCollection<IWebElement> ElementResultArticle => this.Wait.Until(driver => driver.FindElements(By.XPath("//a[@class='elementor-post__read-more']")));

        public IReadOnlyCollection<IWebElement> allElements => driver.FindElements(By.XPath("//*"));

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(Url);
        }

    }

}
