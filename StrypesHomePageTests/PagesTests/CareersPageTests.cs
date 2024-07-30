

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using StrypesHomePageTests.Pages;

namespace StrypesHomePageTests.PagesTests
{
    public class CareersPageTests : BaseTests
    {
        [Test]
        public void Test_CareersPage_Content()
        {
            var careersPage = new CareersPage(driver);
            careersPage.Open();

            Assert.Multiple(() => {
                Assert.That(careersPage.GetPageTitle(), Is.EqualTo("Careers - Strypes"));
                Assert.That(careersPage.GetPageHeadingText, Is.EqualTo("Our awesome team"));
            });
        }

        [Test]
        public void Test_CareersPage_Functionalities()
        {
            var careersPage = new CareersPage(driver);
            careersPage.Open();

            careersPage.ViewButton.Click();

            Assert.That(careersPage.GetPageHeadingText, Is.EqualTo("Automation Quality Assurance Engineer"));
        }




    }
}
