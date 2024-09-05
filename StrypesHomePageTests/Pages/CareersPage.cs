using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;

namespace StrypesHomePageTests.Pages
{
    public class CareersPage : BasePage
    {
        public CareersPage(IWebDriver driver) : base(driver)
        {
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        WebDriverWait Wait;

        public string Url = BaseUrl + "/careers/";
             
        public ReadOnlyCollection<IWebElement> ElementResultArticle => this.Wait.Until(driver => driver.FindElements(By.XPath("//span[@class='elementor-button-text' and text()='View']")));

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(Url);
        }
    }
}
