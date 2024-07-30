
using OpenQA.Selenium;

namespace StrypesHomePageTests.Pages
{
    public class ContactPage : BasePage
    {
        public ContactPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://strypes.eu/contact/";

        public IWebElement ElementHeadingTitle => driver.FindElement(By.XPath("//section[1]/div[2]/div/div/div/div/h1"));
        public IWebElement ElementFirstName => driver.FindElement(By.Id("firstname-9246f6ce-b893-4249-8362-96d17c0861f5"));
        public IWebElement ElementLastName => driver.FindElement(By.Id("lastname-9246f6ce-b893-4249-8362-96d17c0861f5"));
        public IWebElement ElementEmail => driver.FindElement(By.Id("email-9246f6ce-b893-4249-8362-96d17c0861f5"));
        public IWebElement ElementCompany => driver.FindElement(By.Id("company-9246f6ce-b893-4249-8362-96d17c0861f5"));
        public IWebElement ElementMessage => driver.FindElement(By.Id("message-9246f6ce-b893-4249-8362-96d17c0861f5"));
        public IWebElement ElementLegalConsent => driver.FindElement(By.Id("LEGAL_CONSENT.subscription_type_4681882-9246f6ce-b893-4249-8362-96d17c0861f5"));
        public IWebElement ElementSendButton => driver.FindElement(By.CssSelector("//input[@type='submit']"));
        public IWebElement ElementFirstErrorMsg => driver.FindElement(By.XPath("//fieldset[2]/div/ul/li/label")); // "Email must be formatted correctly."
        public IWebElement ElementSecondErrorMsg => driver.FindElement(By.XPath("//fieldset[5]/div/div[1]/div/div/ul/li/label")); // "Please complete this required field."
    }
}
