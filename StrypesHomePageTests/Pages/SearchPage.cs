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

        public readonly string Url = BaseUrl + "/?s/";

        public IWebElement ElementSearchInput => driver.FindElement(By.XPath("//input[@id='elementor-search-form-e64b8f7']"));
        public IWebElement ElementSearchButton => driver.FindElement(By.XPath("//button/i"));

        public ReadOnlyCollection<IWebElement> ElementResultArticle => this.Wait.Until(driver => driver.FindElements(By.XPath("//a[@class='elementor-post__read-more']")));

        public IWebElement ElementResultArticleHeading => driver.FindElement(By.CssSelector("div>h1"));


        public void OpenPage()
        {
            driver.Navigate().GoToUrl(Url);
        }

    }

}
