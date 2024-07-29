using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using StrypesHomePageTests.Pages;

namespace StrypesHomePageTests.PagesTests
{
    public class HomePageTests : BaseTests
    {

        [Test]
        public void Test_HomePage_Content()
        {
            HomePage homePage = new HomePage(driver);
            homePage.Open();

            Assert.Multiple(() => 
            {
                Assert.That(homePage.GetPageTitle(), Is.EqualTo("Strypes | End-to-end software solutions"));
                Assert.That(homePage.GetPageHeadingText, Is.EqualTo("We are Strypes"));
            });
        }

        [Test]
        public void Test_HomePage_Links()
        {
            HomePage homePage = new HomePage(driver);

            homePage.Open();
            homePage.AboutLink.Click();
            Assert.That(new HomePage(driver).IsPageOpen(), Is.True);

            homePage.Open();
            homePage.SurvicesLink.Click();
            Assert.That(new HomePage(driver).IsPageOpen(), Is.True);
        }
    }
}
