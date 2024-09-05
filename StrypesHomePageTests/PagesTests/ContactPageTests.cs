using OpenQA.Selenium.Support.UI;
using StrypesHomePageTests.Pages;

namespace StrypesHomePageTests.PagesTests
{
    public class ContactPageTests : BasePageTests
    {
        [Test]
        public void Test_ContactPage_Content()
        {
            contactPage.OpenPage();
            basePage.AcceptAllCookiesButton.Click();

            Assert.Multiple(() =>
            {
                Assert.That(contactPage.GetPageTitle(), Is.EqualTo("Contact - ICT Strypes"));
                Assert.That(contactPage.GetPageHeadingText, Is.EqualTo("Get in touch"));
            });
        }

        [Test]
        public void Test_ContactPage_NoEmail()
        {
            contactPage.OpenPage();
            basePage.AcceptAllCookiesButton.Click();

            contactPage.ElementSendButton.Click();

            string actualErorMessage = contactPage.ElementSecondErrorMsg[0].Text;
            string expectedErrorMessage = "Please complete this required field.";

            Assert.That(actualErorMessage, Is.EqualTo(expectedErrorMessage), "The required field message is not as expected.");
        }

        [Test]
        public void Test_ContactPage_NotCorrectEmail()
        {
            contactPage.OpenPage();
            basePage.AcceptAllCookiesButton.Click();

            contactPage.ElementEmail.Click();
            contactPage.ElementEmail.SendKeys("not a correct e-mail");
            contactPage.ElementSendButton.Click();

            string actualErrorMessage = contactPage.ElementSecondErrorMsg[0].Text;
            string expectedErrorMessage = "Email must be formatted correctly.";

            Assert.That(actualErrorMessage, Is.EqualTo(expectedErrorMessage), "The required field message is not as expected.");
        }
        
        [Test]
        public void Test_ContactPage_PartiallyNotCorrectEmail()
        {
            contactPage.OpenPage();
            basePage.AcceptAllCookiesButton.Click();

            contactPage.ElementEmail.Click();
            contactPage.ElementEmail.SendKeys("example@domain");
            contactPage.ElementSendButton.Click();

            string actualErrorMessage = contactPage.ElementSecondErrorMsg[0].Text;
            string expectedErrorMessage = "Email must be formatted correctly.";

            Assert.That(actualErrorMessage, Is.EqualTo(expectedErrorMessage), "The required field message is not as expected.");
        }

        [Test]
        public void Test_ContactPage_CorrectRequiredFieldsInput()
        {
            contactPage.OpenPage();
            basePage.AcceptAllCookiesButton.Click();

            contactPage.ElementEmail.Click();
            contactPage.ElementEmail.SendKeys("testuserivb@gmail.com");
            contactPage.ElementLegalConsent.Click();
            contactPage.ElementSendButton.Click();
            
            string actualMessage = contactPage.ElementThankYouMsg.Text;
            string expectedMessage = "Thank you for submitting the form.";

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Submission of contact form is not successful");
        }
    }
}
