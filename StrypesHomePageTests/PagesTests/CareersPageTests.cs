using OpenQA.Selenium.Interactions;
using StrypesHomePageTests.Pages;

namespace StrypesHomePageTests.PagesTests
{
    public class CareersPageTests : BasePageTests
    {
        [Test]
        public void Test_CareersPage_Content()
        {
            careersPage.OpenPage();
            basePage.AcceptAllCookiesButton.Click();

            Assert.Multiple(() => {
                Assert.That(careersPage.GetPageTitle(), Is.EqualTo("Careers - Join the ICT Strypes team"));
                Assert.That(careersPage.GetPageHeadingText, Is.EqualTo("Our awesome team"));
            });
        }

        [Test]
        public void Test_CareersPage_Functionalities()
        {
            careersPage.OpenPage();
            
            var viewButton = careersPage.ElementResultArticle[0];
            Actions actions = new Actions(driver);
            actions.MoveToElement(viewButton).Perform();

            careersPage.ElementResultArticle[0].Click();

            Assert.That(careersPage.GetPageHeadingText, Is.EqualTo("Automation Quality Assurance Engineer"));
        }
    }
}
