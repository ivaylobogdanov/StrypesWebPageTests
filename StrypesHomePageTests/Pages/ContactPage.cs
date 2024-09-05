
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace StrypesHomePageTests.Pages
{
    public class ContactPage : BasePage
    {
        public ContactPage(IWebDriver driver) : base(driver)
        {
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        WebDriverWait Wait;

        public readonly string Url = BaseUrl + "/contact/";

        public IWebElement ElementEmail => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("email-9246f6ce-b893-4249-8362-96d17c0861f5")));
        public IWebElement ElementLegalConsent => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@id='LEGAL_CONSENT.subscription_type_4681882-9246f6ce-b893-4249-8362-96d17c0861f5']")));
        public IWebElement ElementSendButton => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@class='hs-button primary large']")));

        public ReadOnlyCollection<IWebElement> ElementSecondErrorMsg => Wait.Until(driver => driver.FindElements(By.XPath("//label[@class='hs-error-msg hs-main-font-element']"))); // "Please complete this required field."

        public IWebElement ElementThankYouMsg => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'submitted-message')]")));

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(Url);
        }
    }
}
